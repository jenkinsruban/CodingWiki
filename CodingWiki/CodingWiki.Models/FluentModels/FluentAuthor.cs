using CodingWiki.Models.FluentModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki.Models
{
    public class FluentAuthor
    {
        [Key]
        public int AuthorId { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [NotMapped]
        public string FullName => FirstName + " " + LastName;

        public string Location { get; set; }

        //public List<FluentBook> FluentBooks { get; set; }

        public List<FluentBookAuthor> BookAuthors { get; set; }
    }
}
