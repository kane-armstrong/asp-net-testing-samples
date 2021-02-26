using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Api
{
    public record Book(string Title, string Author, string SomeSensitiveThingWeDontWantExposed = null);

    public class BookModel
    {
        public string Title { get; }
        public string Author { get; }

        public BookModel(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }

    public static class BookExtensions
    {
        public static BookModel ToBookModel(this Book book) => new(book.Title, book.Author);
    }

    [Route("books")]
    public class BooksController : ControllerBase
    {
        readonly Book[] _books = {
            new("Design Patterns", "Gamma/Helm/Johnson/Vlissides"),
            new("Introduction to Algorithms", "Cormen/Leiserson/Rivest/Stein"),
            new("Building Microservices", "Newman"),
            new("The Mythical Man Month", "Brooks"),
            new("Discrete Mathematics", "Truss"),
            new("Code Complete", "McConnell"),
            new("Refactoring", "Fowler")
        };

        public ActionResult<BookModel[]> Get() => _books.Select(x => x.ToBookModel()).ToArray();
    }
}