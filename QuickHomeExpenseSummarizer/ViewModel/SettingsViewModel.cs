using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace QuickHomeExpenseSummarizer.ViewModel
{
    public partial class SettingsViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<SourceFolderViewModel> sourceFolders = new();

        [RelayCommand]
        void AddSourceFolder()
        {
            SourceFolderViewModel newSourceFolder = new SourceFolderViewModel();
            SourceFolders.Add(newSourceFolder);
        }
    }
}
