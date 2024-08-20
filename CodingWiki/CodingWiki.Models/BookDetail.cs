using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki.Models
{
    public class BookDetail
    {
        [Key]
        public int BookDetailId { get; set; }

        [Required]
        public int NumberOfChapters { get; set; }

        public int NumberOfPages { get; set; }

        public string Weight { get; set; }

        public Book Book { get; set; }

        [Column("BookId")]
        [ForeignKey("Book")]
        public int ID { get; set; }
    }
}
