# Architektur

Die App ist eine serverseitig gerenderte **Blazor Web App** (`InteractiveServer`).
Sie hält keine eigenen Daten, sondern ruft alle Inhalte über HTTP von der
[Restaurant API](https://api.bigfoot-htcu.com) ab.

## Request-Fluss

```
Browser
   │  (Blazor InteractiveServer über SignalR-Circuit)
   ▼
Restaurant App (ASP.NET Core / Blazor Server)
   │  RestaurantApiService (typed HttpClient)
   ▼
Restaurant API  →  https://api.bigfoot-htcu.com
```

## Wichtige Bausteine

| Ort                              | Verantwortung                                              |
| -------------------------------- | --------------------------------------------------------- |
| `Program.cs`                     | Service-Registrierung (MudBlazor, HttpClient, Render-Mode) |
| `Services/RestaurantApiService.cs` | Typed `HttpClient` gegen die Restaurant API              |
| `Services/ReviewWatcher.cs`      | Pollt im Hintergrund neue Reviews (scoped pro Circuit)     |
| `Models/`                        | DTOs: `RestaurantDto`, `ReviewDto`, `CreateReviewDto`      |
| `Components/`                    | Seiten und wiederverwendbare UI-Komponenten                |

## API-Anbindung

Der `RestaurantApiService` wird in `Program.cs` als **typed HttpClient** mit fester
Base-Address registriert:

```csharp
builder.Services.AddHttpClient<RestaurantApiService>(client =>
{
    client.BaseAddress = new Uri("https://api.bigfoot-htcu.com");
});
```

Die konsumierten Endpunkte (`/restaurants`, `/restaurants/{id}`,
`/restaurants/{id}/reviews`) sind in der
[API-Dokumentation](https://api.bigfoot-htcu.com/scalar/v1) beschrieben.

## Render-Modus

Global ist `InteractiveServer` gesetzt (in `App.razor`) — von MudBlazor benötigt.
Im Workshop wird dieser Modus später variiert, um andere Render-Modi auszuprobieren.
