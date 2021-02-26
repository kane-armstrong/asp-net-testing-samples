using IdentityServer;
using IntegrationTests.Infrastructure.Security;
using Microsoft.Extensions.DependencyInjection;

namespace IntegrationTests.Infrastructure.Hosting
{
    public class TestStartup : Startup
    {
        protected override IServiceCollection AddAuth(IServiceCollection services)
        {
            services.AddFakeAuthentication();
            services.AddFakeAuthorization(Config.PolicyName);

            return services;
        }
    }
}
