using FluentAssertions;
using IntegrationTests.Infrastructure.Hosting;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests.Controllers.BooksController.GetSpec
{
    public class Getting_books_without_auth_bypassed
    {
        [Fact]
        public async Task returns_401_unauthorized()
        {
            const string url = "books";
            using var factory = new BadWebApplicationFactory();
            var client = factory.CreateClient();

            using var response = await client.GetAsync(url);

            response.StatusCode.Should().Be(StatusCodes.Status401Unauthorized);
        }
    }
}
