using System;
using System.Collections.Generic;

namespace CodingWiki.DataAccess.DbFirst;

public partial class Publisher
{
    public int PublisherId { get; set; }

    public string Name { get; set; } = null!;

    public string Location { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
