using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseAndFilterTransactions
{
    public enum DataFormat
    {
        CapitolOne360_Rev0,
        CapitolOne360_Rev1, // some times before 8/29/2020
        CapitolOne360_Rev2,
        QuickSilver_Rev0,
        QuickSilver_Rev1, // some times before 8/29/2020
        BankOfAmerica
    }

    public enum FilterGroup
    {
        Food,
        Utility,
        Gas,
        Amazon
    }

    public class DataColumnIndices
    {
        static DataColumnIndices()
        {
            Format = new Dictionary<DataFormat, DataColumnIndices>();
            Format.Add(DataFormat.CapitolOne360_Rev0, new DataColumnIndices(dateColumnIndex: 7, descriptionColumnIndex: 10, valueColumnIndex: 8));
            Format.Add(DataFormat.CapitolOne360_Rev1, new DataColumnIndices(dateColumnIndex: 1, descriptionColumnIndex: 4, valueColumnIndex: 2));
            Format.Add(DataFormat.CapitolOne360_Rev2, new DataColumnIndices(dateColumnIndex: 2, descriptionColumnIndex: 1, valueColumnIndex: 5));
            Format.Add(DataFormat.BankOfAmerica, new DataColumnIndices(dateColumnIndex: 0, descriptionColumnIndex: 2, valueColumnIndex: 4));
            Format.Add(DataFormat.QuickSilver_Rev0, new DataColumnIndices(dateColumnIndex: 1, descriptionColumnIndex: 4, debitColumnIndex: 6, creditColumnIndex: 7));
            Format.Add(DataFormat.QuickSilver_Rev1, new DataColumnIndices(dateColumnIndex: 0, descriptionColumnIndex: 3, debitColumnIndex: 5, creditColumnIndex: 6));
        }
        public static Dictionary<DataFormat, DataColumnIndices> Format;

        public DataColumnIndices(int dateColumnIndex, int descriptionColumnIndex,
            int? valueColumnIndex = null, int? debitColumnIndex = null, int? creditColumnIndex = null)
        {
            DateColumnIndex = dateColumnIndex;
            ValueColumnIndex = valueColumnIndex;
            DebitColumnIndex = debitColumnIndex;
            CreditColumnIndex = creditColumnIndex;
            DescriptionColumnIndex = descriptionColumnIndex;
        }

        public readonly int DateColumnIndex;
        public readonly int? ValueColumnIndex;
        public readonly int? DebitColumnIndex;
        public readonly int? CreditColumnIndex;
        public readonly int DescriptionColumnIndex;
    }

    public class TransactionData
    {
        public TransactionData(IEnumerable<string> rowData, DataFormat dataFormat)
        {
            m_RowData = new List<string>(rowData);
            m_DataFormat = dataFormat;
        }

        private DataFormat m_DataFormat;

        public IEnumerable<string> RowData
        {
            get { return m_RowData; }
        }
        List<string> m_RowData;

        public string ToCSVFormat()
        {
            string output = string.Empty;
            for (int i = 0; i < m_RowData.Count; ++i)
            {
                if (i > 0) { output += ","; }
                output += m_RowData[i];
            }
            return output;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}", Date, Value, Description);
        }
        public DateTime Date
        {
            get
            {
                return DateTime.Parse(m_RowData[DataColumnIndices.Format[m_DataFormat].DateColumnIndex]);
            }
        }

        public double Value
        {
            get
            {
                if (DataColumnIndices.Format[m_DataFormat].ValueColumnIndex != null)
                {
                    return double.Parse(m_RowData[DataColumnIndices.Format[m_DataFormat].ValueColumnIndex.Value]);
                }
                else if ((DataColumnIndices.Format[m_DataFormat].CreditColumnIndex != null) && (DataColumnIndices.Format[m_DataFormat].DebitColumnIndex != null))
                {
                    string creditString = m_RowData[DataColumnIndices.Format[m_DataFormat].CreditColumnIndex.Value].Trim();
                    string debitString = m_RowData[DataColumnIndices.Format[m_DataFormat].DebitColumnIndex.Value].Trim();

                    if ((creditString.Length > 0) && (debitString.Length == 0))
                    {
                        return double.Parse(creditString) * 1.0;
                    }
                    else if ((creditString.Length == 0) && (debitString.Length > 0))
                    {
                        return double.Parse(debitString) * -1.0;
                    }
                    else
                    {
                        return 0.0;
                    }
                }
                else
                {
                    throw new Exception("There's no value field");
                }
            }
        }

        public string Description
        {
            get
            {
                return m_RowData[DataColumnIndices.Format[m_DataFormat].DescriptionColumnIndex];
            }
        }

        public bool DescriptionContainsAny(List<string> filters)
        {
            int matchCount = (from filter in filters where Description.Contains(filter) select filter).Count();
            return matchCount > 0;
        }
    }
}
