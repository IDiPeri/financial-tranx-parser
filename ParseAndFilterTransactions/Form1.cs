using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ParseAndFilterTransactions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ParseTransactions.OnChanged += ParseTransactions_OnChanged;

            m_RootFolders = new Dictionary<DataFormat, string>();
            //C:\Users\israe\Documents\Financial\Bank of America\Transactions
            m_RootFolders.Add(DataFormat.BankOfAmerica, @"C:\Users\israe\Documents\Financial\Bank of America\Transactions");
            m_RootFolders.Add(DataFormat.CapitolOne360_Rev0, @"C:\Users\israe\Documents\Financial\Capital One 360\Transactions");

            m_FilterGroupKeywords = new Dictionary<FilterGroup, List<string>>();
            List<string> FoodFilterList = new List<string>();
            FoodFilterList.Add("TRADER JOE");
            FoodFilterList.Add("WHOLEFDS");
            FoodFilterList.Add("SHAW S MARKET");
            m_FilterGroupKeywords.Add(FilterGroup.Food, FoodFilterList);

            List<string> UtilityList = new List<string>();
            UtilityList.Add("TARGET");
            UtilityList.Add("CVS PHARMACY");
            UtilityList.Add("WALGREENS");
            m_FilterGroupKeywords.Add(FilterGroup.Utility, UtilityList);

            List<string> GasList = new List<string>();
            GasList.Add("SUNOCO");
            GasList.Add("A-Z SERVICE");
            GasList.Add("SHELL OIL");
            GasList.Add("GULF OIL");
            m_FilterGroupKeywords.Add(FilterGroup.Gas, GasList);

            comboBox_Bank.Items.Add(DataFormat.BankOfAmerica);
            comboBox_Bank.Items.Add(DataFormat.CapitolOne360_Rev0);
            comboBox_Bank.SelectedItem = DataFormat.CapitolOne360_Rev0;

            comboBox_Filter.Items.Add(FilterGroup.Food);
            comboBox_Filter.Items.Add(FilterGroup.Utility);
            comboBox_Filter.Items.Add(FilterGroup.Gas);
            comboBox_Filter.SelectedItem = FilterGroup.Food;
        }

        private void ParseTransactions_OnChanged(object sender, EventArgs args)
        {
            groupBox_FilterTranx.Enabled = (ParseTransactions.AllLoadedTransactions.Count > 0);
            groupBox_SummarizeTranx.Enabled = (ParseTransactions.FilteredTransactions.Count > 0);
            groupBox_Save.Enabled = (ParseTransactions.SummarizedTransactions.Count > 0);
        }

        private Dictionary<DataFormat, string> m_RootFolders;

        private Dictionary<FilterGroup, List<string>> m_FilterGroupKeywords;

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //string sourceFolder = "137697463_03132014_Mar2013_Mar2014";
            //string sourceFile = "137697463_03132014_Mar2013_Mar2014.csv";
            //string outputFile = "137697463_03132014_Mar2013_Mar2014_SummarizedFood.csv";
            //string sourceFolder = "137697463_11112015_Nov2014_Sept2015";
            //string sourceFile = "137697463_11112015.csv";
            //string outputFile = "137697463_11112015_SummarizeUtilities.csv";
            //string sourceFolder = "137697463_06162016_Jan2016_June2016";
            //string sourceFile = "137697463_06162016.csv";
            //string outputFile = "137697463_06162016_SummarizeGroceries.csv";

            string sourceFolder = "137697463_12092016_May2016_Dec2016";
            string sourceFile = "137697463_12092016.csv";
            string outputFile = "137697463_12092016_SummarizeGas.csv";

            string basePath = @"C:\Users\israe\Documents\Financial\Capital One 360\Transactions";
            string outputFolder = sourceFolder;
            string sourceFilePath = Path.Combine(Path.Combine(basePath, sourceFolder), sourceFile);
            string outputFilePath = Path.Combine(Path.Combine(basePath, outputFolder), outputFile);
            
            ParseTransactions.LoadFile(sourceFilePath, DataFormat.CapitolOne360_Rev0);

            List<string> FoodFilterList = new List<string>();
            FoodFilterList.Add("TRADER JOE");
            FoodFilterList.Add("WHOLEFDS");
            FoodFilterList.Add("SHAW S MARKET");
            FoodFilterList.Add("STAR MARKET");
            FoodFilterList.Add("RESERVOIR WINES");
            FoodFilterList.Add("UPPER FALLS DISCOUNT");
            FoodFilterList.Add("HIGHLAND WINE");
            FoodFilterList.Add("STOP & SHOP");
            FoodFilterList.Add("WEGMANS");
            
            List<string> UtilityList = new List<string>();
            UtilityList.Add("TARGET");
            UtilityList.Add("STAPLES");
            UtilityList.Add("CVS PHARMACY");
            UtilityList.Add("WALGREENS");
            UtilityList.Add("BLOOMINGDALE");
            UtilityList.Add("CVS/PHARMACY");
            UtilityList.Add("WAL-MART");
            UtilityList.Add("TJMAXX");
            UtilityList.Add("T J MAXX");

            List<string> GasList = new List<string>();
            GasList.Add("SUNOCO");
            GasList.Add("A-Z SERVICE");
            GasList.Add("SHELL OIL");
            GasList.Add("GULF OIL");
            GasList.Add("EXXONMOBIL");

            //ParseTransactions.Filter(FoodFilterList);
            //ParseTransactions.Filter(UtilityList);
            ParseTransactions.Filter(GasList);

            ParseTransactions.Summarize(DayOfWeek.Friday);

            StreamWriter writer = new StreamWriter(outputFilePath);
            foreach (string line in ParseTransactions.SummarizedTransactions)
            {
                writer.WriteLine(line);
            }
            writer.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter writer = null;
            try
            {
                //MessageBox.Show("Edit code to adjust output folder");
                //string sourceFolder = "Dec2013_Nov2014";
                //string sourceFile = "Dec2013_Nov2014.csv";
                //string outputFile = "Dec2013_Nov2014_SummarizedGas.csv";
                string sourceFolder = "May2016_Dec2016";
                string sourceFile = "2016-May_to_Dec.csv";
                string outputFile = "2016-May_to_Dec_SummarizedFood.csv";

                string basePath = @"C:\Users\israe\Documents\Financial\Bank of America\Transactions";
                string outputFolder = sourceFolder;
                string sourceFilePath = Path.Combine(Path.Combine(basePath, sourceFolder), sourceFile);
                string outputFilePath = Path.Combine(Path.Combine(basePath, outputFolder), outputFile);

                ParseTransactions.LoadFile(sourceFilePath, DataFormat.BankOfAmerica);

                List<string> FoodFilterList = new List<string>();
                FoodFilterList.Add("TRADER JOE");
                FoodFilterList.Add("WHOLEFDS");
                FoodFilterList.Add("SHAW S MARKET");
                FoodFilterList.Add("STAR MARKET");
                FoodFilterList.Add("RESERVOIR WINES");
                FoodFilterList.Add("UPPER FALLS DISCOUNT");
                FoodFilterList.Add("HIGHLAND WINE");
                FoodFilterList.Add("STOP & SHOP");

                List<string> UtilityList = new List<string>();
                UtilityList.Add("TARGET");
                UtilityList.Add("STAPLES");
                UtilityList.Add("CVS PHARMACY");
                UtilityList.Add("WALGREENS");
                UtilityList.Add("BLOOMINGDALE");
                UtilityList.Add("CVS/PHARMACY");
                UtilityList.Add("WAL-MART");

                List<string> GasList = new List<string>();
                GasList.Add("SUNOCO");
                GasList.Add("A-Z SERVICE");
                GasList.Add("SHELL OIL");
                GasList.Add("GULF OIL");
                GasList.Add("EXXONMOBIL");

                ParseTransactions.Filter(FoodFilterList);

                ParseTransactions.Summarize(DayOfWeek.Friday);

                writer = new StreamWriter(outputFilePath);
                foreach (string line in ParseTransactions.SummarizedTransactions)
                {
                    writer.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        private void comboBox_Bank_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_RootFolder.Text = m_RootFolders[(DataFormat)comboBox_Bank.SelectedItem];
        }

        private void buttonSelectSourceFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = textBox_RootFolder.Text;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxFileName.Text = openFileDialog1.FileName;
            }
        }

        private void comboBox_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> list = m_FilterGroupKeywords[(FilterGroup)comboBox_Filter.SelectedItem];
            listBoxFilterKeywords.Items.Clear();
            foreach (string keyword in list)
            {
                listBoxFilterKeywords.Items.Add(keyword);
            }
        }
    }
}
