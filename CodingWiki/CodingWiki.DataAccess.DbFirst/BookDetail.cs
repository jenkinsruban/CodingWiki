using System;
using System.Collections.Generic;

namespace CodingWiki.DataAccess.DbFirst;

public partial class BookDetail
{
    public int BookDetailId { get; set; }

    public int NumberOfChapters { get; set; }

    public int NumberOfPages { get; set; }

    public string Weight { get; set; } = null!;

    public int BookId { get; set; }

    public virtual Book Book { get; set; } = null!;
}
