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
    public partial class SummarizeTranxCtrl : UserControl
    {
        public SummarizeTranxCtrl()
        {
            InitializeComponent();
        }

        private void buttonSummarize_Click(object sender, EventArgs e)
        {
            DayOfWeek dayOfWeek;

            if (radioButton_Sun.Checked) { dayOfWeek = DayOfWeek.Sunday; }
            else if (radioButton_Mon.Checked) { dayOfWeek = DayOfWeek.Monday; }
            else if (radioButton_Tue.Checked) { dayOfWeek = DayOfWeek.Tuesday; }
            else if (radioButton_Wed.Checked) { dayOfWeek = DayOfWeek.Wednesday; }
            else if (radioButton_Thr.Checked) { dayOfWeek = DayOfWeek.Thursday; }
            else if (radioButton_Fri.Checked) { dayOfWeek = DayOfWeek.Friday; }
            else if (radioButton_Sat.Checked) { dayOfWeek = DayOfWeek.Saturday; }
            else
            {
                throw new Exception("No day of week was selected");
            }

            ParseTransactions.Summarize(dayOfWeek);
            label_TranxCount.Text = ParseTransactions.SummarizedTransactions.Count.ToString();
        }
    }
}
