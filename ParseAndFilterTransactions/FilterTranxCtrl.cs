using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParseAndFilterTransactions
{
    public partial class FilterTranxCtrl : UserControl
    {
        List<string> FoodFilterList;
        List<string> GasList;
        List<string> UtilityList;
        List<string> AmazonList;

        public FilterTranxCtrl()
        {
            InitializeComponent();

            //!FIX: save/load to/from file
            FoodFilterList = new List<string>();
            FoodFilterList.Add("TRADER JOE");
            FoodFilterList.Add("WHOLEFDS");
            FoodFilterList.Add("SHAW S MARKET");
            FoodFilterList.Add("STAR MARKET");
            FoodFilterList.Add("RESERVOIR WINES");
            FoodFilterList.Add("UPPER FALLS DISCOUNT");
            FoodFilterList.Add("HIGHLAND WINE");
            FoodFilterList.Add("STOP & SHOP");
            FoodFilterList.Add("WEGMANS");

            UtilityList = new List<string>();
            UtilityList.Add("TARGET");
            UtilityList.Add("STAPLES");
            UtilityList.Add("CVS PHARMACY");
            UtilityList.Add("WALGREENS");
            UtilityList.Add("BLOOMINGDALE");
            UtilityList.Add("CVS/PHARMACY");
            UtilityList.Add("WAL-MART");
            UtilityList.Add("TJMAXX");
            UtilityList.Add("T J MAXX");

            AmazonList = new List<string>();
            AmazonList.Add("Amazon.com");
            AmazonList.Add("AMAZON COM");
            AmazonList.Add("AMAZON MKTPLACE");
            AmazonList.Add("AMZN MKTP");
            AmazonList.Add("AMZN Mktp");

            GasList = new List<string>();
            GasList.Add("SUNOCO");
            GasList.Add("A-Z SERVICE");
            GasList.Add("SHELL OIL");
            GasList.Add("GULF OIL");
            GasList.Add("EXXONMOBIL");

            PopulateListBox(listBox_Food, FoodFilterList);
            PopulateListBox(listBox_Utility, UtilityList);
            PopulateListBox(listBox_Gas, GasList);
            PopulateListBox(listBox_Amazon, AmazonList);
        }

        private void PopulateListBox(ListBox listBox, List<string> values)
        {
            listBox.Items.Clear();
            foreach (string value in values)
            {
                listBox.Items.Add(value);
            }
        }

        private void buttonFilterAll_Click(object sender, EventArgs e)
        {
            if (radioButton_Food.Checked)
            {
                ParseTransactions.Filter(FoodFilterList);
                ParseTransactions.OutputFileNameSuggestion_Filter = "Food";
            }
            else if (radioButton_Utility.Checked)
            {
                ParseTransactions.Filter(UtilityList);
                ParseTransactions.OutputFileNameSuggestion_Filter = "Utility";
            }
            else if (radioButton_Gas.Checked)
            {
                ParseTransactions.Filter(GasList);
                ParseTransactions.OutputFileNameSuggestion_Filter = "Gas";
            }
            else if (radioButton_Amazon.Checked)
            {
                ParseTransactions.Filter(AmazonList);
                ParseTransactions.OutputFileNameSuggestion_Filter = "Amazon";
            }

            label_TranxCount.Text = ParseTransactions.FilteredTransactions.Count.ToString();

            double netValue = (from t in ParseTransactions.FilteredTransactions select t.Value).Sum();
            label_TranxNetValue.Text = netValue.ToString();
        }
    }
}
