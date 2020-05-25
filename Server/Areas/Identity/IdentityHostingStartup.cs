using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BlazorPlanner.Server.Data;
using BlazorPlanner.Server.Models;

[assembly: HostingStartup(typeof(BlazorPlanner.Server.Areas.Identity.IdentityHostingStartup))]
namespace BlazorPlanner.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}