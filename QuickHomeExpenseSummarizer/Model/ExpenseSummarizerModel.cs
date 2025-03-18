using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickHomeExpenseSummarizer.Entity;
using Microsoft.EntityFrameworkCore;

namespace QuickHomeExpenseSummarizer.Model
{
    public class ExpenseSummarizerModel
    {
        public ExpenseSummarizerModel()
        {
            _dataContext = new();
            //!FIX: do I want to do this? how are NEW migration tables created / added to an old db?
            //dataContext.Database.Migrate();
            Settings = new SettingsModel(_dataContext);
        }

        private DataContext _dataContext;

        public SettingsModel Settings { get; }
    }
}
