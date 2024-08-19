using CodingWiki.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki.DataAccess.Configuration
{
    public class FluentBookConfiguration : IEntityTypeConfiguration<FluentBook>
    {
        public void Configure(EntityTypeBuilder<FluentBook> builder)
        {
            builder.ToTable("FluentBook");
            builder.Ignore(u => u.PriceRange);
        }
    }
}
