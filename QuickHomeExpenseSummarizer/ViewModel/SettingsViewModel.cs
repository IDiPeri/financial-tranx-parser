using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;

namespace QuickHomeExpenseSummarizer.ViewModel
{
    public partial class SettingsViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<SourceFolderViewModel> sourceFolders = new();

        [RelayCommand]
        void AddSourceFolder()
        {
            var dialog = new OpenFolderDialog();
            var clickedOK = dialog.ShowDialog();
            if (clickedOK == true)
            {
                SourceFolderViewModel newSourceFolder = new SourceFolderViewModel(dialog.FolderName);
                SourceFolders.Add(newSourceFolder);
            }
        }
    }
}
