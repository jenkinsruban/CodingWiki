using System;
using System.Collections.Generic;

namespace CodingWiki.DataAccess.DbFirst;

public partial class FluentAuthor
{
    public int AuthorId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Location { get; set; } = null!;

    public int? BookId { get; set; }

    public virtual Book? Book { get; set; }

    public virtual ICollection<FluentBookAuthor> FluentBookAuthors { get; set; } = new List<FluentBookAuthor>();
}
