using IntegrationTests.Infrastructure.Security.Authentication;
using IntegrationTests.Infrastructure.Security.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace IntegrationTests.Infrastructure.Security
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        ///     Configures the request pipeline to ensure any requests annotated by <see cref="AuthorizeAttribute"/>
        ///     will automatically succeed. This is useful in development/testing scenarios, where a developer does
        ///     not want to concern themselves with whether or not they have been granted authorization to execute a
        ///     given action.
        /// </summary>
        /// <param name="services">The service collection instance to register authorization configuration with.</param>
        /// <param name="policies">A set of policy names to configure to automatically pass any authorization checks.</param>
        public static IServiceCollection AddFakeAuthorization(this IServiceCollection services, params string[] policies)
        {
            services.AddAuthorization(options =>
            {
                foreach (var policy in policies)
                {
                    options.AddPolicy(policy, p => p.Requirements.Add(new TestRequirement()));
                }
            });
            services.AddSingleton<IAuthorizationHandler, TestRequirementHandler>();
            return services;
        }

        /// <summary>
        ///     Configures the request pipeline to ensure any authentication challenges automatically succeed.  This is useful
        ///     in development/testing scenarios, where a developer does not want to concern themselves with unnecessarily
        ///     authenticating.
        /// </summary>
        /// <param name="services">The service collection instance to register authentication configuration with.</param>
        public static IServiceCollection AddFakeAuthentication(this IServiceCollection services)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = TestAuthenticationConstants.Scheme;
                options.DefaultChallengeScheme = TestAuthenticationConstants.Scheme;
            })
            .AddTestAuthentication();
            return services;
        }
    }
}
