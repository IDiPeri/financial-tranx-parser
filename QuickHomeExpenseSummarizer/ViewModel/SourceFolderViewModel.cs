using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuickHomeExpenseSummarizer.Model;

namespace QuickHomeExpenseSummarizer.ViewModel
{
    public partial class SourceFolderViewModel : ObservableObject
    {
        public SourceFolderViewModel(SourceFolderModel sourceFolderModel, string folderPath)
        {
            model = sourceFolderModel;

            //!FIX: take SourceFolderModel to init ourselves
            FullFolderPath = folderPath;
        }

        private SourceFolderModel model;

        //!FIX: how do I update model, SourceFolderModel.FullFolderPath? via internal events?
        //!FIX: how do I initialize data since I may need to get it from the UI OR from the DB
        [ObservableProperty]
        string fullFolderPath;

        // !FIX: collection of files
        //       refresh file list command
    }
}
