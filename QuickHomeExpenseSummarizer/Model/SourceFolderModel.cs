using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickHomeExpenseSummarizer.Model
{
    public class SourceFolderModel
    {
        public SourceFolderModel(string folderPath)
        {
            FullFolderPath = folderPath;
        }

        public string FullFolderPath { get; set; }
    }
}
