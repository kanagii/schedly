namespace Schedly.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = "";
    public string Email { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // One user owns many events and many reviews
    public List<ScheduleEvent> Events { get; set; } = new();
    public List<Review> Reviews { get; set; } = new();
}
