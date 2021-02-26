using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public static class Config
    {
        public const string PolicyName = "AllBookApi";

        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new("book-api", "Book API")
            };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new()
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "book-api" }
                }
            };
    }
}