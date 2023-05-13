namespace LiftTracker.Server.Models
{
  public class Plan
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; } = string.Empty;
    public List<WeekTemplate> Weeks { get; set; } = new List<WeekTemplate>();
    public DayOfWeek StartingDayOfWeek { get; set; }
    public User User { get; set; }
    public bool IsActive { get; set; }
  }
}
