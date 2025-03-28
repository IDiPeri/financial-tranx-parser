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
using QuickHomeExpenseSummarizer.Model;

namespace QuickHomeExpenseSummarizer.ViewModel
{
    public partial class SettingsViewModel : ObservableValidator // ObservableObject
    {
        public SettingsViewModel(SettingsModel settingsModel)  //!FIX: init from SettingsModel
        {
            //!FIX: take SettingsModel to init ourselves
            DummyCheck = 1234; //!FIX:

            model = settingsModel;

            sourceFolders = new();

            //!FIX: init sourceFolders with model.SourceFolders
            foreach (var sourceFolderModel in model.SourceFolders)
            {
                SourceFolderViewModel sourceFolderViewModel = new SourceFolderViewModel(sourceFolderModel);
                SourceFolders.Add(sourceFolderViewModel);
            }
        }

        private SettingsModel model;

        //!FIX: https://learn.microsoft.com/en-us/dotnet/communitytoolkit/mvvm/observablevalidator#simple-property
        [ObservableProperty]
        ObservableCollection<SourceFolderViewModel> sourceFolders;

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
#if false   //!FIX: migrate code
                //!FIX: we need to pass data context to model c'tor BUT view model shouldn't be coupled to the
                // data context and entity framework objects.
                // SOLUTION:
                // 1) add public method to settings view model to add folder
                // 2) add public method to settings model to add folder which implicitly passes data context
                SourceFolderModel sourceFolderModel = new SourceFolderModel(dialog.FolderName);

                //!FIX: create new SourceFolderModel and init SourceFolderViewModel from it
                // keep our collection of models up to date.
                SourceFolderViewModel newSourceFolder = new SourceFolderViewModel(sourceFolderModel);
                SourceFolders.Add(newSourceFolder);
#else
                AddSourceFolder(dialog.FolderName);
#endif
                ValidateAllProperties();

                if (HasErrors)
                {
                    //!FIX: this isn't right - dialog pops up but displays nothing ==> need to do as service that launch dlg
                    //https://youtu.be/omo1kzRGK_M?t=4472
                    MessageBox.Show("You did something wrong!");
                    /* https://stackoverflow.com/questions/16877671/showing-a-message-box-from-the-viewmodel-is-a-violation-of-mvvm-how-to-avoid
                     */
                }
            }
        }

        public SourceFolderViewModel AddSourceFolder(string folderPath)
        {
            SourceFolderModel sourceFolderModel = model.AddSourceFolder(folderPath);
            SourceFolderViewModel sourceFolderViewModel = new SourceFolderViewModel(sourceFolderModel);
            SourceFolders.Add(sourceFolderViewModel);
            return sourceFolderViewModel;
        }
    }
}
