using FluentAssertions;
using IntegrationTests.Infrastructure.Hosting;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests.Controllers.BooksController.GetSpec
{
    public class Getting_books
    {
        [Fact]
        public async Task returns_200_ok()
        {
            const string url = "books";
            using var factory = new MyWebApplicationFactory();
            var client = factory.CreateClient();

            using var response = await client.GetAsync(url);

            response.StatusCode.Should().Be(StatusCodes.Status200OK);
        }
    }
}
