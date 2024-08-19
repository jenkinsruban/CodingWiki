using System;
using System.Collections.Generic;

namespace CodingWiki.DataAccess.DbFirst;

public partial class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Isbn { get; set; } = null!;

    public decimal Price { get; set; }

    public int PublisherId { get; set; }

    public virtual BookDetail? BookDetail { get; set; }

    public virtual ICollection<FluentAuthor> FluentAuthors { get; set; } = new List<FluentAuthor>();

    public virtual Publisher Publisher { get; set; } = null!;
}
