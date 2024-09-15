using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ParseAndFilterTransactions
{
    public class ParseTransactions
    {
        static ParseTransactions()
        {
            AllLoadedTransactions = new List<TransactionData>();
            FilteredTransactions = new List<TransactionData>();
            SummarizedTransactions = new List<string>();

            OutputFileNameSuggestion_Loaded = string.Empty;
            OutputFileNameSuggestion_Filter = string.Empty;
            OutputFileNameSuggestion_Summarize = string.Empty;
        }

        public static List<TransactionData> AllLoadedTransactions { get; set; }
        public static List<TransactionData> FilteredTransactions { get; set; }
        public static List<string> SummarizedTransactions { get; set; }
        public static List<string> LastDescriptionFilter { get; set; }

        public static EventHandler<EventArgs> OnChanged;

        public static string OutputFileNameSuggestion_Loaded { get; set; }
        public static string OutputFileNameSuggestion_Filter { get; set; }
        public static string OutputFileNameSuggestion_Summarize { get; set; }

        private static void FireOnChanged()
        {
            if (OnChanged != null)
            {
                OnChanged(typeof(ParseTransactions), EventArgs.Empty);
            }
        }

        public static void Clear()
        {
            AllLoadedTransactions = new List<TransactionData>();
            FilteredTransactions = new List<TransactionData>();
            SummarizedTransactions = new List<string>();
        }

        public static int LoadFile(string fileName, DataFormat dataFormat, bool append=false)
        {   //!FIX: need to make sure we don't have duplicate transactions
            if (!append)
            {
                AllLoadedTransactions = new List<TransactionData>();
            }
            FilteredTransactions = new List<TransactionData>();
            SummarizedTransactions = new List<string>();

            string[] inputLines = File.ReadAllLines(fileName);

            int duplicateCount = 0;
            bool firstLine = true;
            foreach (string line in inputLines)
            {
                //if ((line.Trim() != string.Empty) && (char.IsNumber(line.Trim()[0])))   //!FIX: quick silver starts with text
                if ((line.Trim() != string.Empty) && !firstLine)
                {
                    string[] inputColumns = line.Split(',');    //!FIX: can't handle quote'd text with commas in it!
                    TransactionData data = new TransactionData(inputColumns, dataFormat);
                    int matches = (from d in AllLoadedTransactions
                                   where d.ToCSVFormat() == data.ToCSVFormat()
                                   select d).Count();
                    if (matches == 0)
                    {
                        AllLoadedTransactions.Add(data);
                    }
                    else
                    {
                        duplicateCount++;
                    }
                }

                firstLine = false;
            }

            FireOnChanged();

            return duplicateCount;
        }

        public static void Filter(List<string> descriptionFilters)
        {
            SummarizedTransactions = new List<string>();

            LastDescriptionFilter = descriptionFilters;
            FilteredTransactions = new List<TransactionData>(from data in AllLoadedTransactions
                                                             where data.DescriptionContainsAny(LastDescriptionFilter)
                                                             select data);

            FireOnChanged();
        }

        public static void Summarize(DayOfWeek startOfWeek)
        {
            SummarizedTransactions = new List<string>();
            IEnumerable<TransactionData> orderedFilterTransxList = from trasnx in FilteredTransactions orderby trasnx.Date ascending select trasnx;

            if (orderedFilterTransxList.Count() > 0)
            {
                // Determine the full date range to fit within weeks
                DateTime minDate = orderedFilterTransxList.First().Date;
                DateTime maxDate = orderedFilterTransxList.Last().Date;

                DateTime? startDate = null;
                for(DateTime currentStartDate = minDate; currentStartDate<maxDate; currentStartDate += TimeSpan.FromDays(1))
                {
                    if (currentStartDate.DayOfWeek == startOfWeek)
                    {
                        startDate = currentStartDate;
                        break;
                    }
                }

                DateTime? endDate = null;
                DateTime? lastDate = null;
                for (DateTime currentEndDate = minDate; currentEndDate <= maxDate; currentEndDate += TimeSpan.FromDays(1))
                {
                    if (currentEndDate.DayOfWeek == startOfWeek)
                    {
                        endDate = lastDate;
                    }
                    lastDate = currentEndDate;
                }

                if ((startDate != null) && (endDate != null))
                {
                    if ((endDate.Value - startDate.Value).TotalDays > 7)
                    {
                        DateTime lastStartDate = endDate.Value - TimeSpan.FromDays(7);

                        for (DateTime date = startDate.Value; date < lastStartDate; date += TimeSpan.FromDays(7))
                        {
                            IEnumerable<TransactionData> currentWeek = from data in orderedFilterTransxList
                                                                        where
                                                                            ((data.Date >= date) && (data.Date < date + TimeSpan.FromDays(7)))
                                                                        select data;

                            double sum = (from data in currentWeek select data.Value).Sum();
                            SummarizedTransactions.Add(string.Format("{0}, {1}, {2}", date, date + TimeSpan.FromDays(7), sum));
                        }
                    }
                    else
                    {
                        throw new Exception("There's less than 1 weeks worth of data");
                    }
                }
                else
                {
                    throw new Exception("The start and end time are undefined");
                }
            }
            else
            {
                throw new Exception("No data was parsed from the file");
            }

            FireOnChanged();
        }

        public static void ParseFile(string fileName, List<string> descriptionFilters, DayOfWeek startOfWeek, DataFormat dataFormat)
        {
            string[] inputLines = File.ReadAllLines(fileName);

            List<TransactionData> transactions = new List<TransactionData>();
            foreach (string line in inputLines)
            {
                if ((line.Trim() != string.Empty) && (char.IsNumber( line.Trim()[0])))
                {
                    string[] inputColumns = line.Split(',');
                    TransactionData data = new TransactionData(inputColumns, dataFormat);

                    if (data.DescriptionContainsAny(descriptionFilters))
                    {
                        transactions.Add(data);
                    }
                }
            }

            IEnumerable<TransactionData> orderedFilterTransxList = from trasnx in transactions orderby trasnx.Date ascending select trasnx;

            if (orderedFilterTransxList.Count() > 0)
            {
                // Determine the full date range to fit within weeks
                DateTime minDate = orderedFilterTransxList.First().Date;
                DateTime maxDate = orderedFilterTransxList.Last().Date;

                DateTime? startDate = null;
                foreach (TransactionData data in orderedFilterTransxList)
                {
                    if (data.Date.DayOfWeek == startOfWeek)
                    {
                        startDate = data.Date;
                        break;
                    }
                }

                DateTime? endDate = null;
                DateTime? lastDate = null;
                foreach (TransactionData data in orderedFilterTransxList)
                {
                    if (data.Date.DayOfWeek == startOfWeek)
                    {
                        endDate = lastDate;
                    }
                    lastDate = data.Date;
                }

                if ((startDate != null) && (endDate != null))
                {
                    if ((endDate.Value - startDate.Value).TotalDays > 7)
                    {
                        DateTime lastStartDate = endDate.Value - TimeSpan.FromDays(7);

                        string newfilePath = Path.GetDirectoryName(fileName);
                        newfilePath = Path.Combine(newfilePath, Path.GetFileNameWithoutExtension(fileName));
                        newfilePath += "_OUTPUT.csv";

                        StreamWriter writer = new StreamWriter(newfilePath);
                        try
                        {
                            writer.Write("Week Start, Week End, Sum, Description Contains");
                            foreach (string filter in descriptionFilters)
                            {
                                writer.Write(" [{0}]", filter);
                            }
                            writer.WriteLine();

                            for (DateTime date = startDate.Value; date < lastStartDate; date += TimeSpan.FromDays(7))
                            {
                                IEnumerable<TransactionData> currentWeek = from data in orderedFilterTransxList
                                                                           where
                                                                               ((data.Date >= date) && (data.Date < date + TimeSpan.FromDays(7)))
                                                                           select data;

                                double sum = (from data in currentWeek select data.Value).Sum();
                                writer.WriteLine("{0}, {1}, {2}", date, date + TimeSpan.FromDays(7), sum);
                            }
                        }
                        finally
                        {
                            writer.Close();
                        }
                    }
                    else
                    {
                        throw new Exception("There's less than 1 weeks worth of data");
                    }
                }
                else
                {
                    throw new Exception("The start and end time are undefined");
                }
            }
            else
            {
                throw new Exception("No data was parsed from the file");
            }
        }
    }
}
