namespace RestaurantApp.Models;

/// <summary>
/// Ein einzelnes Review für ein Restaurant, wie es von der API zurückgegeben wird.
/// </summary>
public class ReviewDto
{
    public int Id { get; set; }
    public int RestaurantId { get; set; }
    public string Author { get; set; } = string.Empty;
    public int Stars { get; set; }
    public string Comment { get; set; } = string.Empty;
    public DateTime Date { get; set; }
}
