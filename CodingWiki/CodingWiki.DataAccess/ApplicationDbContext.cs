using CodingWiki.DataAccess.Configuration;
using CodingWiki.DataAccess.Migrations;
using CodingWiki.Models;
using CodingWiki.Models.FluentModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.Extensions.Logging;

namespace CodingWiki.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Book> Books { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<FluentAuthor> Authors { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<BookDetail> BookDetails { get; set; }

        public DbSet<FluentBook> FluentBooks { get; set; }

        public DbSet<FluentBookDetail> FluentBookDetails { get; set; }

        public DbSet<FluentBookAuthor> BookAuthors { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=localhost;Database=Books;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true")
            //    .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, Microsoft.Extensions.Logging.LogLevel.Information);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new FluentBookConfiguration());
            modelBuilder.ApplyConfiguration(new FluentBookDetailConfiguration());

            modelBuilder.Entity<FluentAuthor>().ToTable("FluentAuthor");
            modelBuilder.Entity<FluentBookAuthor>().ToTable("FluentBookAuthor");

            modelBuilder.Entity<FluentBookAuthor>().HasKey(u => u.Id);

            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);

            var bookList = new List<Book>()
            {
                new Book  {  ID = 1, ISBN = "123B12", Title = "Spider Man", Price = 10.00m, PublisherId = 1 },
                new Book { ID = 2, ISBN = "123B13", Title = "He-man and the universe", Price = 12.00m, PublisherId = 1 },
                new Book  {  ID = 3, ISBN = "123B14", Title = "Fake Sunday", Price = 10.00m, PublisherId = 2 },
                new Book  {  ID = 4, ISBN = "123B15", Title = "Cookie Jar", Price = 10.00m, PublisherId = 2 },
                new Book  {  ID = 5, ISBN = "123B16", Title = "Cloudy Forest", Price = 10.00m, PublisherId = 3 },
            };
            modelBuilder.Entity<Book>().HasData(bookList);

            var publisherList = new List<Publisher>()
            {
                new Publisher {PublisherId = 1, Name = "Pub1 Jimmy", Location = "Chicago"},
                new Publisher {PublisherId = 2, Name = "Pub2 John", Location = "NewYork"},
                new Publisher {PublisherId = 3, Name = "Pub3 Ben", Location = "Hawaii"}
            };
            modelBuilder.Entity<Publisher>().HasData(publisherList);

            var categories = new List<Category>()
            {
               new Category {Id = 1, Name = "Category1"},
               new Category {Id = 2, Name = "Category2"},
               new Category {Id = 3, Name = "Category3"},
            };

            modelBuilder.Entity<Category>().HasData(categories);

            base.OnModelCreating(modelBuilder);
        }
    }
}