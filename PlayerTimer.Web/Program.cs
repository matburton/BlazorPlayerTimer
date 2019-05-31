
using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

using PlayerTimer.Core.Domain;

namespace PlayerTimer.Web
{
    public class Program
    {
        public static void Main()
        {
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                                 .UseBlazorStartup<Startup>()
                                 .Build()
                                 .Run();
        }

        public sealed class Startup
        {
            public void Configure(IComponentsApplicationBuilder app)
            {
                app.AddComponent<App>("app");
            }

            public void ConfigureServices(IServiceCollection services)
            {
                services.AddTransient(_ => new Game(TimeSpan.FromMinutes(10)));

                services.AddTransient<ICollection<Player>>(_ => new List<Player>());
            }
        }
    }
}