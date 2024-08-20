using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki.Models
{
    [Table("Publishers")]
    public class Publisher
    {
        public int PublisherId { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public List<Book> Books { get; set; }
    }
}
