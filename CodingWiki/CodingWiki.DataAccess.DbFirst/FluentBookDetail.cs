using System;
using System.Collections.Generic;

namespace CodingWiki.DataAccess.DbFirst;

public partial class FluentBookDetail
{
    public int BookDetailId { get; set; }

    public int NoOfChapters { get; set; }

    public int NumberOfPages { get; set; }

    public string Weight { get; set; } = null!;

    public int BookId { get; set; }

    public virtual FluentBook Book { get; set; } = null!;
}
