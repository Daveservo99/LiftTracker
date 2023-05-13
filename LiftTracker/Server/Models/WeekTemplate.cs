namespace LiftTracker.Server.Models
{
  public class WeekTemplate
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; } = string.Empty;
    public List<PlannedSession> Day1 { get; set; } = new List<PlannedSession>();
    public List<PlannedSession> Day2 { get; set; } = new List<PlannedSession>();
    public List<PlannedSession> Day3 { get; set; } = new List<PlannedSession>();
    public List<PlannedSession> Day4 { get; set; } = new List<PlannedSession>();
    public List<PlannedSession> Day5 { get; set; } = new List<PlannedSession>();
    public List<PlannedSession> Day6 { get; set; } = new List<PlannedSession>();
    public List<PlannedSession> Day7 { get; set; } = new List<PlannedSession>();
  }
}
