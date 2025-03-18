using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickHomeExpenseSummarizer.Entity;

namespace QuickHomeExpenseSummarizer.Model
{
    public class SourceFolderModel
    {
        public SourceFolderModel(DataContext dataContext, string folderPath)
        {
            _dataContext = dataContext;

            FullFolderPath = folderPath;

            //!FIX: how do we get a unique Id?
            // SourceFolderId is auto set when SaveChanges() is called because of DatabaseGenerated attribute
            //_sourceFolderEntity = new SourceFolder{ SourceFolderId = 1, Name = folderPath };
            _sourceFolderEntity = new SourceFolder { Name = folderPath };
            _dataContext.SourceFolders.Add(_sourceFolderEntity);
            int writeCount = _dataContext.SaveChanges();
        }

        private DataContext _dataContext;
        private SourceFolder _sourceFolderEntity;

        public string FullFolderPath { get; set; }
    }
}
