using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki.Models
{
    public class FluentBookDetail
    {
        [Key]
        public int BookDetailId { get; set; }

        [Required]
        public int NumberOfChapters { get; set; }

        public int NumberOfPages { get; set; }

        public string Weight { get; set; }

        public int BookId { get; set; }

        public FluentBook FluentBook { get; set; }
    }
}
