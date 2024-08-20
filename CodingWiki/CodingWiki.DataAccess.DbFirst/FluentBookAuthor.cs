using System;
using System.Collections.Generic;

namespace CodingWiki.DataAccess.DbFirst;

public partial class FluentBookAuthor
{
    public int Id { get; set; }

    public int BookId { get; set; }

    public int AuthorId { get; set; }

    public virtual FluentAuthor Author { get; set; } = null!;

    public virtual FluentBook Book { get; set; } = null!;
}
