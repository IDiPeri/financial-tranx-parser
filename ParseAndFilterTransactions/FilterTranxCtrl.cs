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
        Dictionary<FilterGroup, List<string>> GroupFilters;

        public FilterTranxCtrl()
        {
            InitializeComponent();

            var FoodFilterList = new List<string>();
            FoodFilterList.Add("TRADER JOE");
            FoodFilterList.Add("WHOLEFDS");
            FoodFilterList.Add("SHAW S MARKET");
            FoodFilterList.Add("STAR MARKET");
            FoodFilterList.Add("RESERVOIR WINES");
            FoodFilterList.Add("UPPER FALLS DISCOUNT");
            FoodFilterList.Add("HIGHLAND WINE");
            FoodFilterList.Add("STOP & SHOP");
            FoodFilterList.Add("WEGMANS");

            var UtilityList = new List<string>();
            UtilityList.Add("TARGET");
            UtilityList.Add("STAPLES");
            UtilityList.Add("CVS PHARMACY");
            UtilityList.Add("WALGREENS");
            UtilityList.Add("BLOOMINGDALE");
            UtilityList.Add("CVS/PHARMACY");
            UtilityList.Add("WAL-MART");
            UtilityList.Add("TJMAXX");
            UtilityList.Add("T J MAXX");

            var AmazonList = new List<string>();
            AmazonList.Add("Amazon.com");
            AmazonList.Add("AMAZON COM");
            AmazonList.Add("AMAZON MKTPLACE");
            AmazonList.Add("AMZN MKTP");
            AmazonList.Add("AMZN Mktp");

            var GasList = new List<string>();
            GasList.Add("SUNOCO");
            GasList.Add("A-Z SERVICE");
            GasList.Add("SHELL OIL");
            GasList.Add("GULF OIL");
            GasList.Add("EXXONMOBIL");

            GroupFilters = new Dictionary<FilterGroup, List<string>>();
            GroupFilters.Add(FilterGroup.Food, FoodFilterList);
            GroupFilters.Add(FilterGroup.Utility, UtilityList);
            GroupFilters.Add(FilterGroup.Amazon, AmazonList);
            GroupFilters.Add(FilterGroup.Gas, GasList);

            PopulateListBox(listBox_Food, GroupFilters[FilterGroup.Food]);
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
                ParseTransactions.Filter(GroupFilters[FilterGroup.Food]);
                ParseTransactions.OutputFileNameSuggestion_Filter = FilterGroup.Food.ToString();
            }
            else if (radioButton_Utility.Checked)
            {
                ParseTransactions.Filter(GroupFilters[FilterGroup.Utility]);
                ParseTransactions.OutputFileNameSuggestion_Filter = FilterGroup.Utility.ToString();
            }
            else if (radioButton_Gas.Checked)
            {
                ParseTransactions.Filter(GroupFilters[FilterGroup.Gas]);
                ParseTransactions.OutputFileNameSuggestion_Filter = FilterGroup.Gas.ToString();
            }
            else if (radioButton_Amazon.Checked)
            {
                ParseTransactions.Filter(GroupFilters[FilterGroup.Amazon]);
                ParseTransactions.OutputFileNameSuggestion_Filter = FilterGroup.Amazon.ToString();
            }

            label_TranxCount.Text = ParseTransactions.FilteredTransactions.Count.ToString();

            double netValue = (from t in ParseTransactions.FilteredTransactions select t.Value).Sum();
            label_TranxNetValue.Text = netValue.ToString();
        }
    }
}
