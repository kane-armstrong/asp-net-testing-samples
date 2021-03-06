﻿using IdentityServer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.PlatformAbstractions;
using System.IO;

namespace IntegrationTests.Infrastructure.Hosting
{
    public sealed class BadWebApplicationFactory : WebApplicationFactory<Startup>
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