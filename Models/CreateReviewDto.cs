using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Models;

/// <summary>
/// Payload zum Erstellen eines neuen Reviews (POST /restaurants/{id}/reviews).
/// Die Data-Annotation-Attribute sind bereits vorverdrahtet, sodass der
/// DataAnnotationsValidator der AddReview-EditForm direkt funktioniert.
/// </summary>
public class CreateReviewDto
{
    [Required(ErrorMessage = "Please enter your name.")]
    public string Author { get; set; } = string.Empty;

    [Range(1, 5, ErrorMessage = "Please give a rating between 1 and 5 stars.")]
    public int Stars { get; set; }

    [Required(ErrorMessage = "Please enter a comment.")]
    public string Comment { get; set; } = string.Empty;
}
