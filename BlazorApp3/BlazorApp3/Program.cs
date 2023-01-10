using BlazorApp3;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = Startup.InitializeApp(args);
var app = builder.Build();
await app.RunAsync();
