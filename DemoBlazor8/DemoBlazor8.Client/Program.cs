using DemoBlazor8.Client.Services;
using DemoBlazor8.Core.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<IDatiCategorie, ServizioCategorieWASM>();

await builder.Build().RunAsync();
