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
    public class FluentBookDetailConfiguration : IEntityTypeConfiguration<FluentBookDetail>
    {
        public void Configure(EntityTypeBuilder<FluentBookDetail> modelBuilder)
        {
            modelBuilder.ToTable("FluentBookDetail");
            modelBuilder.Property(u => u.NumberOfChapters).HasColumnName("NoOfChapters");
            modelBuilder.Property(u => u.NumberOfChapters).IsRequired();
            modelBuilder.HasKey(u => u.BookDetailId);
            modelBuilder.HasOne(b => b.FluentBook).
                WithOne(b => b.FluentBookDetail).HasForeignKey<FluentBookDetail>(u => u.BookId);
        }
    }
}
