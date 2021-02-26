using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace IntegrationTests.Infrastructure.Security.Authentication
{
    public class TestAuthenticationOptions : AuthenticationSchemeOptions
    {
        public virtual ClaimsIdentity Identity { get; } = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.Name, Guid.NewGuid().ToString()),
        }, TestAuthenticationConstants.AuthenticationType);
    }
}
