using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki.Models
{
    [Table("SubCategories")]
    public class SubCategory
    {
        public int SubCategoryId { get; set; }

        [MaxLength(50)]
        public string Name{ get; set; }
    }
}
