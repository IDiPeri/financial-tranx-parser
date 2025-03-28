using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
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
            foreach(var sourceFolder in _dataContext.SourceFolders)
            {
                SourceFolderModel sourceFolderModel = new SourceFolderModel(_dataContext, sourceFolder);
                SourceFolders.Add(sourceFolderModel);
            }
        }

        private DataContext _dataContext;

        public List<SourceFolderModel> SourceFolders;

        public SourceFolderModel AddSourceFolder(string folderPath)
        {
            //!FIX: to be consistent *we* should create a new SourceFolder (from folderPath)
            // and added to _dataContext.SourceFolders collection here since the c'tor does that here
            // yet this method passes off folderPath.
            SourceFolderModel sourceFolderModel = new SourceFolderModel(_dataContext, folderPath);
            SourceFolders.Add(sourceFolderModel);
            return sourceFolderModel;
        }
    }
}
