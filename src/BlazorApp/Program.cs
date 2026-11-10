using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp;
using BlazorApp.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HttpClient für die Kommunikation mit dem Backend (Port anpassen, falls nötig)
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5049/") });

// Warenkorb-Service registrieren
builder.Services.AddScoped<CartService>();

await builder.Build().RunAsync();