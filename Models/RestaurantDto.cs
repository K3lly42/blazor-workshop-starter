namespace RestaurantApp.Models;

/// <summary>
/// Ein Restaurant, wie es von der API zurückgegeben wird. <see cref="AvgRating"/>
/// wird serverseitig aus den Reviews des Restaurants berechnet — hier ist es
/// nur lesend.
/// </summary>
public class RestaurantDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Cuisine { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public decimal AvgRating { get; set; }
}
