using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace QuickHomeExpenseSummarizer.ViewModel
{
    public partial class ExpenseSummarizerViewModel : ObservableObject
    {
        public ExpenseSummarizerViewModel()
        {
            //!FIX: to communicate StrongReferenceMessenger.Default.Send()
            //      with other decoupled view models
            // https://youtu.be/omo1kzRGK_M?t=1893

            //!FIX: other videos on using messagers:
            //https://www.youtube.com/watch?v=vD17OetzGXc

            //!FIX: create ExpenseSummarizerModel
            //  - it needs to check if DB exists already or if it needs to create one?
            //  - and migrate it?
        }

        //!FIX: use ObservableRecipient so we can override 
        /* https://youtu.be/omo1kzRGK_M?t=3410
        protected override void OnActivated()
        {
            base.OnActivated();
        }

        protected override void OnDeactivated()
        {
            base.OnDeactivated();
        }
        */
        //!FIX: ObservableValidator does NOT have OnActived() / OnDeactived()
        // https://youtu.be/omo1kzRGK_M?t=4114

        [ObservableProperty]
        SettingsViewModel settings = new();
    }
}
