namespace Schedly.Models;

public class ScheduleEvent
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public DateOnly Date { get; set; }
    public TimeOnly Start { get; set; }
    public TimeOnly End { get; set; }
    public EventCategory Category { get; set; } = EventCategory.Work;
    public string? Notes { get; set; }

    // Foreign key: the user who owns this event
    public int UserId { get; set; }
    public User? User { get; set; }

    public TimeSpan Duration => End.ToTimeSpan() - Start.ToTimeSpan();
}
