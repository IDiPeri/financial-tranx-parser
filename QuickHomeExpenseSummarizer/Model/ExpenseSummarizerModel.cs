using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickHomeExpenseSummarizer.Model
{
    public class ExpenseSummarizerModel
    {
        public ExpenseSummarizerModel()
        {
            Settings = new SettingsModel();
        }

        public SettingsModel Settings { get; }
    }
}
