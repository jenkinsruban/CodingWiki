using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodingWiki.DataAccess.DbFirst;

public partial class BooksContext : DbContext
{
    public BooksContext()
    {
    }

    public BooksContext(DbContextOptions options)
    {

    }

    public BooksContext(DbContextOptions<BooksContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookDetail> BookDetails { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<FluentAuthor> FluentAuthors { get; set; }

    public virtual DbSet<FluentBook> FluentBooks { get; set; }

    public virtual DbSet<FluentBookAuthor> FluentBookAuthors { get; set; }

    public virtual DbSet<FluentBookDetail> FluentBookDetails { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    public virtual DbSet<SubCategory> SubCategories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=Books;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasIndex(e => e.PublisherId, "IX_Books_PublisherId");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isbn).HasColumnName("ISBN");
            entity.Property(e => e.Price).HasColumnType("decimal(10, 5)");

            entity.HasOne(d => d.Publisher).WithMany(p => p.Books).HasForeignKey(d => d.PublisherId);
        });

        modelBuilder.Entity<BookDetail>(entity =>
        {
            entity.HasIndex(e => e.BookId, "IX_BookDetails_BookId").IsUnique();

            entity.HasOne(d => d.Book).WithOne(p => p.BookDetail).HasForeignKey<BookDetail>(d => d.BookId);
        });

        modelBuilder.Entity<FluentAuthor>(entity =>
        {
            entity.HasKey(e => e.AuthorId);

            entity.ToTable("FluentAuthor");

            entity.HasIndex(e => e.BookId, "IX_FluentAuthor_BookID");

            entity.Property(e => e.BookId).HasColumnName("BookID");
            entity.Property(e => e.FirstName).HasMaxLength(50);

            entity.HasOne(d => d.Book).WithMany(p => p.FluentAuthors).HasForeignKey(d => d.BookId);
        });

        modelBuilder.Entity<FluentBook>(entity =>
        {
            entity.ToTable("FluentBook");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isbn).HasColumnName("ISBN");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<FluentBookAuthor>(entity =>
        {
            entity.ToTable("FluentBookAuthor");

            entity.HasIndex(e => e.AuthorId, "IX_FluentBookAuthor_AuthorId");

            entity.HasIndex(e => e.BookId, "IX_FluentBookAuthor_BookId");

            entity.HasOne(d => d.Author).WithMany(p => p.FluentBookAuthors).HasForeignKey(d => d.AuthorId);

            entity.HasOne(d => d.Book).WithMany(p => p.FluentBookAuthors).HasForeignKey(d => d.BookId);
        });

        modelBuilder.Entity<FluentBookDetail>(entity =>
        {
            entity.HasKey(e => e.BookDetailId);

            entity.ToTable("FluentBookDetail");

            entity.HasIndex(e => e.BookId, "IX_FluentBookDetail_BookId").IsUnique();

            entity.HasOne(d => d.Book).WithOne(p => p.FluentBookDetail).HasForeignKey<FluentBookDetail>(d => d.BookId);
        });

        modelBuilder.Entity<SubCategory>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
