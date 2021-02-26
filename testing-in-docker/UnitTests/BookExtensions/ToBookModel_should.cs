using Api;
using FluentAssertions;
using Xunit;

namespace UnitTests.BookExtensions
{
    public class ToBookModel_should
    {
        [Fact]
        public void map_title_correctly()
        {
            const string title = "The Book Title";
            Book book = new(title, "");
            var sut = book.ToBookModel();
            sut.Title.Should().Be(title);
        }

        [Fact]
        public void map_author_correctly()
        {
            const string author = "The Author";
            Book book = new("", author);
            var sut = book.ToBookModel();
            sut.Author.Should().Be(author);
        }
    }
}
