using MudBlazor.Services;
using RestaurantApp.Components;
using RestaurantApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Services zum Container hinzufügen.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// MudBlazor-UI-Services (Snackbar, Dialoge, Popovers, Theming).
builder.Services.AddMudServices();

// Typed HttpClient für die Workshop-API.
// Workshop API: https://api.bigfoot-htcu.com — Scalar docs: https://api.bigfoot-htcu.com/scalar/v1
builder.Services.AddHttpClient<RestaurantApiService>(client =>
{
    client.BaseAddress = new Uri("https://api.bigfoot-htcu.com");
});

var app = builder.Build();

// HTTP-Request-Pipeline konfigurieren.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // Der Standardwert für HSTS beträgt 30 Tage. Für Produktionsszenarien solltest du diesen ggf. anpassen, siehe https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
