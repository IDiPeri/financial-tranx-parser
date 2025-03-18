using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickHomeExpenseSummarizer.Entity
{
    public class SourceFolder
    {
        //!FIX: [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Key, Required]   // from https://youtu.be/defBg85T8AU?t=411
        public int SourceFolderId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
