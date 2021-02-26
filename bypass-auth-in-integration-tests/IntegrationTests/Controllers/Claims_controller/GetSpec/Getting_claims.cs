using FluentAssertions;
using IntegrationTests.Infrastructure;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests.Controllers.Claims_controller.GetSpec
{
    public class Getting_claims : IClassFixture<TestFixture>
    {
        private readonly TestFixture _testFixture;

        public Getting_claims(TestFixture testFixture)
        {
            _testFixture = testFixture;
        }

        [Fact]
        public async Task returns_200_ok()
        {
            //+ Arrange
            const string url = "test";

            //+ Act
            using var response = await _testFixture.Client.GetAsync(url);

            //+ Assert
            response.StatusCode.Should().Be(StatusCodes.Status200OK);
        }
    }
}
