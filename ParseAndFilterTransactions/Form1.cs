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
        }

        private void ParseTransactions_OnChanged(object sender, EventArgs args)
        {
            groupBox_FilterTranx.Enabled = (ParseTransactions.AllLoadedTransactions.Count > 0);
            groupBox_SummarizeTranx.Enabled = (ParseTransactions.FilteredTransactions.Count > 0);
            groupBox_Save.Enabled = (ParseTransactions.SummarizedTransactions.Count > 0);
        }
    }
}
