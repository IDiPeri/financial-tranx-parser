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
    public class CategoryItem
    {
        public CategoryItem()
        {
        }
        /* !FIX: ease of use c'tor
        public CategoryItem(FilterCategory parent)
        {
            FilterCategory = parent;
        }
        */

        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryItemId { get; set; }


        //public FilterCategory FilterCategory { get; set; }  //!FIX: automatically generated FilterCategoryId db column?
        //!FIX: [ForeignKey("FilterCategory")]
        public string Name { get; set; } = string.Empty;

        // Foreign Key
        public int FilterCategoryId { get; set; }
        // Navigation Property
        public FilterCategory FilterCategory { get; set; }
    }
}
