using IntegrationTests.Infrastructure.Hosting;
using System;
using System.Net.Http;

namespace IntegrationTests.Infrastructure
{
    public class TestFixture : IDisposable
    {
        private readonly CustomWebApplicationFactory _webApplicationFactory;

        private HttpClient _client;

        public TestFixture()
        {
            _webApplicationFactory = new CustomWebApplicationFactory();
        }

        public HttpClient Client
        {
            get
            {
                if (_client != null)
                    return _client;
                _client = _webApplicationFactory.CreateClient();
                return _client;
            }
        }
        public void Dispose()
        {
            _webApplicationFactory.Dispose();
            _client?.Dispose();
        }
    }
}