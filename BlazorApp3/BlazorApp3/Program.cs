global using BlazorApp3.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp3;


var builder = Startup.InitializeApp(args);

await builder.Build().RunAsync();
