using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorPlanner.Shared.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorPlanner.Client
{
    public class Program
    {
        private const string URL = "https://localhost:44354"; // change as required

        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddScoped<AuthenticationService>(s =>
            {
                return new AuthenticationService(URL);
            });
            builder.Services.AddScoped<PlansService>(s =>
            {
                return new PlansService(URL);
            });
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddOptions(); // required for authentication
            builder.Services.AddAuthorizationCore();//required for authentication
            builder.Services.AddScoped<AuthenticationStateProvider, LocalAuthenticationStateProvider>(); //required for authentication
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
