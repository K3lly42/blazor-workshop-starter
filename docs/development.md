# Entwicklung

## Voraussetzungen

- [.NET SDK 10](https://dotnet.microsoft.com/download)

## Starten

```bash
cd RestaurantApp
dotnet run
```

Anschließend die ausgegebene `https://localhost:<port>`-URL öffnen. Die App spricht
direkt die öffentliche [Restaurant API](https://api.bigfoot-htcu.com) an – es ist
also keine lokal laufende API nötig.

## Projektstruktur

```
Components/
  App.razor                 # Document head/body, MudBlazor-Assets, render mode
  Routes.razor
  Layout/MainLayout.razor   # MudBlazor-Provider
  Layout/NavMenu.razor      # Restaurants- + Counter-Links
  Pages/
    Home.razor
    Counter.razor           # Referenzbeispiel
    RestaurantList.razor     # /restaurants
    RestaurantDetail.razor   # /restaurants/{Id:int}
  RestaurantCard.razor
  StarRating.razor
  AddReview.razor
Models/                     # RestaurantDto, ReviewDto, CreateReviewDto
Services/                   # RestaurantApiService, ReviewWatcher
```

## Workshop-TODOs

Der Starter enthält bewusst unfertige Stellen, jeweils mit einem `TODO`-Block markiert.
Empfohlene Reihenfolge:

1. **`Services/RestaurantApiService.cs`** – die vier gestubbten Methoden implementieren
   (`GetRestaurantsAsync`, `GetRestaurantAsync`, `GetReviewsAsync`, `PostReviewAsync`).
2. **`Components/StarRating.razor`** – wiederverwendbare Sterne-Komponente.
3. **`Components/RestaurantCard.razor`** – Restaurant-Kachel mit Link zur Detailseite.
4. **`Components/Pages/RestaurantList.razor`** – Liste aller Restaurants.
5. **`Components/Pages/RestaurantDetail.razor`** – Restaurant + Reviews.
6. **`Components/AddReview.razor`** – `EditForm` zum Anlegen neuer Reviews.

> Was bereits vorverdrahtet ist (MudBlazor, HttpClient, DTOs, Navigation), ist im
> Repo-`README.md` im Detail beschrieben.
