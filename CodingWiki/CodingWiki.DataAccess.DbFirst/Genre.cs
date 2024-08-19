using System;
using System.Collections.Generic;

namespace CodingWiki.DataAccess.DbFirst;

public partial class Genre
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayOrder { get; set; } = null!;
}
