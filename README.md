# RestaurantApp — Blazor-Workshop-Starter

Ein **.NET 10 Blazor Web App**-Starter für den Workshop. Die gesamte langweilige
Infrastruktur (MudBlazor, HttpClient, DTOs, Routing, Scaffolding) ist bereits
verdrahtet, damit du dich auf das Lernen der **Blazor-Mechanik** konzentrieren kannst.

## Workshop-API

- **Base URL:** https://api.bigfoot-htcu.com
- **API-Doku (Scalar):** https://api.bigfoot-htcu.com/scalar/v1

## Ausführen

```bash
dotnet run
```

Öffne dann die ausgegebene `https://localhost:<port>`-URL. Die **Counter**-Seite
bleibt als Referenzbeispiel für grundlegende Komponenten-Mechanik erhalten.

## ✅ Bereits vorkonfiguriert (nicht anfassen — das ist für dich erledigt)

- **MudBlazor 9.x** installiert und registriert (`AddMudServices()`), mit den
  Theme-/Popover-/Dialog-/Snackbar-Providern in `MainLayout.razor`, dem CSS/den Fonts
  in `App.razor` und `@using MudBlazor` in `_Imports.razor`.
- **Globaler render mode** auf `InteractiveServer` gesetzt in `App.razor`
  (von MudBlazor benötigt — wird später geändert, um andere render modes auszuprobieren).
- **Typed HttpClient** `RestaurantApiService` registriert mit der API-Base-Address
  (`Program.cs`).
- **DTOs** in `Models/`: `RestaurantDto`, `ReviewDto`, `CreateReviewDto`
  (Letzteres trägt bereits die Validierungs-Attribute).
- **Navigation** bereinigt: ein *Restaurants*-Link zeigt auf `/restaurants`.
- **Scaffolding-Dateien** (siehe unten) mit `@page`-Direktiven, Parametern und TODOs.

## 📝 Deine TODOs (in dieser Reihenfolge)

1. **`Services/RestaurantApiService.cs`** — implementiere die vier gestubbten Methoden
   (`GetRestaurantsAsync`, `GetRestaurantAsync`, `GetReviewsAsync`,
   `PostReviewAsync`). Jede hat einen Kommentar mit ihrem Endpoint und einem Tipp.
2. **`Components/StarRating.razor`** — wiederverwendbare Sterne-Anzeige-/Bearbeiten-Komponente
   (`Value`, `ReadOnly`, `ValueChanged`).
3. **`Components/RestaurantCard.razor`** — zeige ein Restaurant (Name, Cuisine,
   Adresse, Bild, Durchschnittsbewertung via `StarRating`) und verlinke auf seine Detailseite.
4. **`Components/Pages/RestaurantList.razor`** (`/restaurants`) — lade alle
   Restaurants, zeige einen Lade-Indikator und rendere pro Eintrag eine `RestaurantCard`.
5. **`Components/Pages/RestaurantDetail.razor`** (`/restaurants/{Id:int}`) —
   lade ein Restaurant + seine Reviews, zeige Infos, Bewertung und die Review-Liste.
6. **`Components/AddReview.razor`** — `EditForm` + `DataAnnotationsValidator`,
   das ein neues Review via `PostReviewAsync` abschickt; binde es in die Detailseite ein.

> Jede Datei enthält einen prominenten `TODO`-Block, der genau beschreibt, was zu bauen ist.

## Projektstruktur

```
Components/
  App.razor              # Document head/body, MudBlazor-Assets, render mode
  Routes.razor
  Layout/MainLayout.razor# MudBlazor-Provider liegen hier
  Layout/NavMenu.razor   # Restaurants- + Counter-Links
  Pages/
    Home.razor
    Counter.razor        # bleibt als Referenzbeispiel erhalten
    RestaurantList.razor # TODO
    RestaurantDetail.razor # TODO
  RestaurantCard.razor   # TODO
  StarRating.razor       # TODO
  AddReview.razor        # TODO
Models/                  # RestaurantDto, ReviewDto, CreateReviewDto
Services/                # RestaurantApiService (gestubbt)
```
