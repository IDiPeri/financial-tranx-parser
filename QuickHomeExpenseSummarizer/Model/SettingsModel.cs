using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using QuickHomeExpenseSummarizer.Entity;

namespace QuickHomeExpenseSummarizer.Model
{
    public class SettingsModel
    {
        public SettingsModel(DataContext dataContext)
        {
            _dataContext = dataContext;
            SourceFolders = new();

            //!FIX: if DB exists load here otherwise do nothing
            //!FIX: create local lists _dataContext.SourceFolders.ToList();
        }

        private DataContext _dataContext;

        public List<SourceFolderModel> SourceFolders;

        public SourceFolderModel AddSourceFolder(string folderPath)
        {
            SourceFolderModel sourceFolderModel = new SourceFolderModel(_dataContext, folderPath);
            SourceFolders.Add(sourceFolderModel);
            return sourceFolderModel;
        }
    }
}
