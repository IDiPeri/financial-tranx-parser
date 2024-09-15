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

            //comboBox_Bank.Items.Add(DataFormat.BankOfAmerica);    //!FIX:
            //comboBox_Bank.Items.Add(DataFormat.CapitolOne360_Rev0);
            //comboBox_Bank.SelectedItem = DataFormat.CapitolOne360_Rev0;

            //comboBox_Filter.Items.Add(FilterGroup.Food);
            //comboBox_Filter.Items.Add(FilterGroup.Utility);
            //comboBox_Filter.Items.Add(FilterGroup.Gas);
            //comboBox_Filter.SelectedItem = FilterGroup.Food;
        }

        private void ParseTransactions_OnChanged(object sender, EventArgs args)
        {
            groupBox_FilterTranx.Enabled = (ParseTransactions.AllLoadedTransactions.Count > 0);
            groupBox_SummarizeTranx.Enabled = (ParseTransactions.FilteredTransactions.Count > 0);
            groupBox_Save.Enabled = (ParseTransactions.SummarizedTransactions.Count > 0);
        }

        private Dictionary<DataFormat, string> m_RootFolders;

        private Dictionary<FilterGroup, List<string>> m_FilterGroupKeywords;

        private void comboBox_Bank_SelectedIndexChanged(object sender, EventArgs e)
        {   //!FIX: remove
            //textBox_RootFolder.Text = m_RootFolders[(DataFormat)comboBox_Bank.SelectedItem];
        }

        private void buttonSelectSourceFile_Click(object sender, EventArgs e)
        {   //!FIX: remove
            //openFileDialog1.FileName = textBox_RootFolder.Text;

            //if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    textBoxFileName.Text = openFileDialog1.FileName;
            //}
        }

        private void comboBox_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {   //!FIX: remove
            //List<string> list = m_FilterGroupKeywords[(FilterGroup)comboBox_Filter.SelectedItem];
            //listBoxFilterKeywords.Items.Clear();
            //foreach (string keyword in list)
            //{
            //    listBoxFilterKeywords.Items.Add(keyword);
            //}
        }
    }
}
