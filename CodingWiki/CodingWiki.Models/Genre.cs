using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki.Models
{
    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string DisplayOrder { get; set; }
    }
}
