using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ParseAndFilterTransactions
{
    public partial class LoadFilesCtrl : UserControl
    {
        public LoadFilesCtrl()
        {
            InitializeComponent();

            InitializeFileLists();
        }

        string path_CapitalOne360_Rev0 = @"C:\Users\israe\Documents\Financial\Transactions\Capital One 360\Rev0";
        string path_CapitalOne360_Rev1 = @"C:\Users\israe\Documents\Financial\Transactions\Capital One 360\Rev1";
        string path_CapitalOne360_Rev2 = @"C:\Users\israe\Documents\Financial\Transactions\Capital One 360\Rev2";
        int Current_CapitalOne360_Rev = 2;

        string path_Quicksilver_Rev0 = @"C:\Users\israe\Documents\Financial\Transactions\Quicksilver\Rev0";
        string path_Quicksilver_Rev1 = @"C:\Users\israe\Documents\Financial\Transactions\Quicksilver\Rev1";
        int Current_Quicksilver_Rev = 1;

        string path_BankOfAmerica = @"C:\Users\israe\Documents\Financial\Transactions\Bank of America";

        private void InitializeFileLists()
        {
            if (Current_CapitalOne360_Rev == 0)
            {
                InitializeFileList(checkedListBox_CapitalOne360Files, path_CapitalOne360_Rev0);
            }
            else if (Current_CapitalOne360_Rev == 1)
            {
                InitializeFileList(checkedListBox_CapitalOne360Files, path_CapitalOne360_Rev1);
            }
            else
            {
                InitializeFileList(checkedListBox_CapitalOne360Files, path_CapitalOne360_Rev2);
            }
            if (Current_Quicksilver_Rev == 0)
            {
                InitializeFileList(checkedListBox_QuicksilverFiles, path_Quicksilver_Rev0);
            }
            else
            {
                InitializeFileList(checkedListBox_QuicksilverFiles, path_Quicksilver_Rev1);
            }
            InitializeFileList(checkedListBox_BankOfAmericaFiles, path_BankOfAmerica);
        }

        private static void InitializeFileList(CheckedListBox listBox, string path)
        {
            listBox.Items.Clear();
            foreach (string file in Directory.EnumerateFiles(path))
            {
                listBox.Items.Add(Path.GetFileName(file), isChecked: false);
            }
        }

        private int LoadFiles(CheckedListBox listBox, string path, DataFormat dataFormat)
        {
            int duplicateCount = 0;
            foreach (string file in listBox.CheckedItems)
            {
                string filePath = Path.Combine(path, file);
                duplicateCount += ParseTransactions.LoadFile(filePath, dataFormat, append: true);
            }
            return duplicateCount;
        }

        private void buttonLoadAll_Click(object sender, EventArgs e)
        {
            ParseTransactions.Clear();
            int duplicateCount = 0;
            if (Current_CapitalOne360_Rev == 0)
            {
                duplicateCount += LoadFiles(checkedListBox_CapitalOne360Files, path_CapitalOne360_Rev0, DataFormat.CapitolOne360_Rev0);
            }
            else if (Current_CapitalOne360_Rev == 1)
            {
                duplicateCount += LoadFiles(checkedListBox_CapitalOne360Files, path_CapitalOne360_Rev1, DataFormat.CapitolOne360_Rev1);
            }
            else
            {
                duplicateCount += LoadFiles(checkedListBox_CapitalOne360Files, path_CapitalOne360_Rev2, DataFormat.CapitolOne360_Rev2);
            }
            if (Current_Quicksilver_Rev == 0)
            {
                duplicateCount += LoadFiles(checkedListBox_QuicksilverFiles, path_Quicksilver_Rev0, DataFormat.QuickSilver_Rev0);
            }
            else
            {
                duplicateCount += LoadFiles(checkedListBox_QuicksilverFiles, path_Quicksilver_Rev1, DataFormat.QuickSilver_Rev1);
            }
            duplicateCount += LoadFiles(checkedListBox_BankOfAmericaFiles, path_BankOfAmerica, DataFormat.BankOfAmerica);
            label_TranxCount.Text = ParseTransactions.AllLoadedTransactions.Count.ToString();

            if (duplicateCount > 0)
            {
                MessageBox.Show(string.Format("There were {0} duplicates filtered out", duplicateCount));
            }

            if (ParseTransactions.AllLoadedTransactions.Count > 0)
            {
                DateTime min = (from t in ParseTransactions.AllLoadedTransactions select t.Date).Min();
                DateTime max = (from t in ParseTransactions.AllLoadedTransactions select t.Date).Max();

                string outputFormat = "yyyy-MM-dd";
                ParseTransactions.OutputFileNameSuggestion_Loaded = string.Format("{0}_to_{1}", min.ToString(outputFormat), max.ToString(outputFormat));
            }
            else
            {
                ParseTransactions.OutputFileNameSuggestion_Loaded = "na";
            }
            //ParseTransactions.OutputFileNameSuggestion_Loaded
        }
    }
}
