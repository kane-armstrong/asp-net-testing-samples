using IdentityServer4;
using IdentityServerHost;
using IntegrationTests.Infrastructure.Security;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IntegrationTests.Infrastructure.Hosting
{
    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration) : base(configuration)
        {
        }

        protected override IServiceCollection AddAuthorization(IServiceCollection services)
        {
            services.AddFakeAuthentication();
            services.AddFakeAuthorization(IdentityServerConstants.LocalApi.PolicyName);

            return services;
        }
    }
}
