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
    public class FilterCategory
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FilterCategoryId { get; set; }
        public string Name { get; set; } = string.Empty;

        // Navigation Properties
        //!FIX: https://www.youtube.com/watch?v=CHBKouYSp2c
        //!FIX: https://www.learnentityframeworkcore.com/relationships#navigation-properties
        public ICollection<CategoryItem> Items { get; set; } = new List<CategoryItem>();
    }
}
