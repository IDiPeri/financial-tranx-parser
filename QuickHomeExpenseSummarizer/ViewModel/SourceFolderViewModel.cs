using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace QuickHomeExpenseSummarizer.ViewModel
{
    public partial class SourceFolderViewModel : ObservableObject
    {
        [ObservableProperty]
        string fullFolderPath = "Alpha";

        // !FIX: collection of files
        //       refresh file list command
    }
}
