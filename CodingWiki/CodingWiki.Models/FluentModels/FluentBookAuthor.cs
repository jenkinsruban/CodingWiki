using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki.Models.FluentModels
{
    public class FluentBookAuthor
    {

        public int Id { get; set; }

        [ForeignKey("FluentBook")]
        public int BookId { get; set; }

        [ForeignKey("FluentAuthor")]
        public  int  AuthorId { get; set; }

       
        public FluentAuthor FluentAuthor { get; set; }

        public FluentBook FluentBook { get; set; }
    }
}
