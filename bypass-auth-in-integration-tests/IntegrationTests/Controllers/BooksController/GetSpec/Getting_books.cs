using FluentAssertions;
using IntegrationTests.Infrastructure.Hosting;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests.Controllers.BooksController.GetSpec
{
    public class Getting_claims
    {
        [Fact]
        public async Task returns_200_ok()
        {
            //+ Arrange
            const string url = "books";

            using var factory = new MyWebApplicationFactory();
            var client = factory.CreateClient();

            //+ Act
            using var response = await client.GetAsync(url);

            //+ Assert
            response.StatusCode.Should().Be(StatusCodes.Status200OK);
        }
    }
}
