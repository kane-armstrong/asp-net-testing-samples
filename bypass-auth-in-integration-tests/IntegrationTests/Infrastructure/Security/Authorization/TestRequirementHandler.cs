using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace IntegrationTests.Infrastructure.Security.Authorization
{
    public class TestRequirementHandler : AuthorizationHandler<TestRequirement>
    {
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            TestRequirement requirement)
        {
            context.Succeed(requirement);
            return Task.CompletedTask;
        }
    }
}
