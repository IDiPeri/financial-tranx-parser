using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;

namespace QuickHomeExpenseSummarizer.ViewModel
{
    public partial class SettingsViewModel : ObservableValidator // ObservableObject
    {
        public SettingsViewModel()
        {
            //!FIX: take SettingsModel to init ourselves
            DummyCheck = 1234; //!FIX:
        }

        //!FIX: https://learn.microsoft.com/en-us/dotnet/communitytoolkit/mvvm/observablevalidator#simple-property
        [ObservableProperty]
        ObservableCollection<SourceFolderViewModel> sourceFolders = new();

        [ObservableProperty]
        [Required]
        int? dummyCheck;

        [RelayCommand]
        void AddSourceFolder()  //!FIX: async Task works with RelayCommand also https://youtu.be/omo1kzRGK_M?t=3990
        {
            var dialog = new OpenFolderDialog();
            var clickedOK = dialog.ShowDialog();
            if (clickedOK == true)
            {
                SourceFolderViewModel newSourceFolder = new SourceFolderViewModel(dialog.FolderName);
                SourceFolders.Add(newSourceFolder);
                ValidateAllProperties();

                if (HasErrors)
                {
                    //!FIX: this isn't right - dialog pops up but displays nothing
                    //https://youtu.be/omo1kzRGK_M?t=4472
                    MessageBox.Show("You did something wrong!");
                    /* https://stackoverflow.com/questions/16877671/showing-a-message-box-from-the-viewmodel-is-a-violation-of-mvvm-how-to-avoid
                     */
                }
            }
        }
    }
}
