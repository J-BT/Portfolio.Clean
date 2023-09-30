using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Portfolio.Clean.BlazorUI;
using Portfolio.Clean.BlazorUI.Contracts;
using Portfolio.Clean.BlazorUI.Services;
using Portfolio.Clean.BlazorUI.Services.Base;
using System.Globalization;
using System.Reflection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Default: Without API  
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Link the UI to the API
builder.Services.AddHttpClient<IClient, Client>(client => client.BaseAddress = new Uri
    ("https://localhost:7073"));

builder.Services.AddScoped<IContactEmailService, ContactEmailService>();
builder.Services.AddScoped<IPCLogService, PCLogService>();
builder.Services.AddScoped<IProjectService, ProjectService>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddLanguageContainer(Assembly.GetExecutingAssembly(), CultureInfo.GetCultureInfo("fr-FR"));

await builder.Build().RunAsync();
