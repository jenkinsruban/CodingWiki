using CodingWiki.DataAccess;
using CodingWiki.DataAccess.DbFirst;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

public class Program
{
    static void Main(string[] args)
    {
        GetBooksFromSQL();
        GetSingleOrDefaultBook();
        CreateBook();
        GetBooks();
    }

    static void GetSingleOrDefaultBook()
    {
        DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
        optionsBuilder.UseSqlServer("Server=localhost;Database=Books;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        
        


        using var context = new BooksContext(optionsBuilder.Options);
        var book = context.Books.SingleOrDefault(c => c.Isbn == "123B145");
        book = context.Books.Single(c => c.Isbn == "123B14");
    }

    static void GetBooksFromSQL()
    {
        using var context = new BooksContext();
        var books = context.Books.FromSql($"EXECUTE dbo.spGetBooks");
        foreach (var book in books)
        {
            Console.WriteLine(book.Title);
        }
        Console.Read();
    }

    static void GetBooks()
    {
        using var context = new BooksContext();
        var books = context.Books.ToList();
        foreach (var book in books)
        {
            Console.WriteLine(book.Title);
        }
        Console.Read();
    }

    static void CreateBook()
    {
        using var context = new BooksContext();
        context.Books.Add(new Book() { Title = "Hello SomeWhere", Isbn = "123B185", Price = 20, PublisherId = 3 });
        context.SaveChanges();
    }

    static void LikeFunction()
    {
        using var context = new BooksContext();
        var books = context.Books.Where(f => EF.Functions.Like(f.Isbn, "12"));
        foreach (var book in books)
        {
            Console.WriteLine(book.Title);
        }
        Console.Read();
    }
}