using System;
using System.Collections.Generic;

namespace CodingWiki.DataAccess.DbFirst;

public partial class FluentBook
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Isbn { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<FluentBookAuthor> FluentBookAuthors { get; set; } = new List<FluentBookAuthor>();

    public virtual FluentBookDetail? FluentBookDetail { get; set; }
}
