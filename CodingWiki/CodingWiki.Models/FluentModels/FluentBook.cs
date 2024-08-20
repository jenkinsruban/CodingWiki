using CodingWiki.Models.FluentModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingWiki.Models
{
    public class FluentBook
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string ISBN { get; set; }

        public decimal Price { get; set; }


        [NotMapped]
        public string PriceRange { get; set; }

        public FluentBookDetail FluentBookDetail { get; set; }
        public List<FluentBookAuthor> BookAuthors { get; set; }
    }
}