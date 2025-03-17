﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;


namespace QuickHomeExpenseSummarizer.Model
{
    public class SettingsModel
    {
        public SettingsModel()
        {
            SourceFolders = new();

            //!FIX: if DB exists load here otherwise do nothing
        }

        public List<SourceFolderModel> SourceFolders;
    }
}
