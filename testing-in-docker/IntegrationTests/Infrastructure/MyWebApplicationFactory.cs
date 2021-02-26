using System.IO;
using Api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.PlatformAbstractions;

namespace IntegrationTests.Infrastructure
{
    public sealed class MyWebApplicationFactory : WebApplicationFactory<Startup>
    {
        protected override IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            var applicationPath = Path.GetFullPath(PlatformServices.Default.Application.ApplicationBasePath);
            builder.UseContentRoot(applicationPath);
            base.ConfigureWebHost(builder);
        }
    }
}