using System.Net.Http.Json;
using RestaurantApp.Models;

namespace RestaurantApp.Services;

/// <summary>
/// Typed HttpClient für die Workshop-Restaurant-API.
///
/// Base address (konfiguriert in Program.cs): https://api.bigfoot-htcu.com
/// API-Dokumentation (Scalar):                https://api.bigfoot-htcu.com/scalar/v1
///
/// Alle Methoden unten sind bewusst NICHT IMPLEMENTIERT — sie zu implementieren
/// ist Teil des Workshops. Nutze <see cref="_http"/> zusammen mit den
/// System.Net.Http.Json-Hilfsmethoden (GetFromJsonAsync, PostAsJsonAsync, …).
/// </summary>
public class RestaurantApiService(HttpClient http)
{
    private readonly HttpClient _http = http;

    // TODO: Implementieren.
    // GET /restaurants
    // Alle Restaurants abrufen (jedes enthält bereits die berechnete AvgRating).
    // Tipp: return await _http.GetFromJsonAsync<List<RestaurantDto>>("/restaurants") ?? [];
    public Task<List<RestaurantDto>> GetRestaurantsAsync()
    {
        throw new NotImplementedException();
    }

    // TODO: Implementieren.
    // GET /restaurants/{id}
    // Ein einzelnes Restaurant anhand seiner id abrufen. Die API gibt 404 zurück,
    // wenn es nicht existiert — entscheide, wie du das behandeln willst (z. B. null zurückgeben).
    public Task<RestaurantDto?> GetRestaurantAsync(int id)
    {
        throw new NotImplementedException();
    }

    // TODO: Implementieren.
    // GET /restaurants/{restaurantId}/reviews
    // Alle Reviews für das angegebene Restaurant abrufen.
    public Task<List<ReviewDto>> GetReviewsAsync(int restaurantId)
    {
        throw new NotImplementedException();
    }

    // TODO: Implementieren.
    // POST /restaurants/{restaurantId}/reviews
    // Das neue Review senden (body: CreateReviewDto). Die API validiert die Sterne (1-5)
    // und dass author/comment nicht leer sind und gibt bei einem Validierungsfehler 400 zurück.
    // Tipp: nutze _http.PostAsJsonAsync(...) und prüfe response.EnsureSuccessStatusCode().
    public Task PostReviewAsync(int restaurantId, CreateReviewDto dto)
    {
        throw new NotImplementedException();
    }
}
