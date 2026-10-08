namespace Schedly.Models;

public class Review
{
    public int Id { get; set; }
    public int Rating { get; set; }          // 1-5 stars
    public string Comment { get; set; } = "";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Foreign key: the user who wrote this review
    public int UserId { get; set; }
    public User? User { get; set; }
}
