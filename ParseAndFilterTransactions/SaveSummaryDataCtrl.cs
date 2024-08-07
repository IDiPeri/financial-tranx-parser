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
    public partial class SaveSummaryDataCtrl : UserControl
    {
        public SaveSummaryDataCtrl()
        {
            InitializeComponent();
            textBox_Path.Text = @"C:\Users\HomeUser\Documents\Financial\Transactions\";
            ParseTransactions.OnChanged += ParseTransactions_OnChanged;
        }

        private void ParseTransactions_OnChanged(object sender, EventArgs args)
        {
            textBox_File.Text = ParseTransactions.OutputFileNameSuggestion_Loaded + "_" + ParseTransactions.OutputFileNameSuggestion_Filter + ".csv";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string outputFilePath = Path.Combine(textBox_Path.Text, textBox_File.Text);
            StreamWriter writer = new StreamWriter(outputFilePath);
            foreach (string line in ParseTransactions.SummarizedTransactions)
            {
                writer.WriteLine(line);
            }
            writer.Close();
        }
    }
}
