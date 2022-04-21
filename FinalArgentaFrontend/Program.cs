using Blazored.LocalStorage;
using FinalArgentaFrontend;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(@"https://argenta.azurewebsites.net/") });
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazorise(opts =>
{
    opts.ChangeTextOnKeyPress = true;
})
.AddBootstrap5Providers()
.AddFontAwesomeIcons();

await builder.Build().RunAsync();
