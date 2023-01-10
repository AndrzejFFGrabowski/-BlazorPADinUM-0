﻿using BlazorApp3.Interfaces;
using BlazorApp3.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorApp3
{
    public static class Startup
    {
        public static WebAssemblyHostBuilder InitializeApp(String[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            Configure(builder);
            ConfigureServices(builder);
            return builder;
        }
        private static void ConfigureServices(WebAssemblyHostBuilder builder)
        {
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            //builder.Services.AddSingleton<IPersonService, PersonService>();
        }

        private static void Configure(WebAssemblyHostBuilder builder)
        {
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");
        }
    }
}
