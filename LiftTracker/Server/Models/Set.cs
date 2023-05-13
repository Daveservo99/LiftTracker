namespace LiftTracker.Server.Models
{
  public class Set
  {
    public int Id { get; set; }
    public Session Session { get; set; }
    public Exercise Exercise { get; set; }
    public int Reps { get; set; }
    public int Weight { get; set; }
    public DateTime DateTime { get; set; }
  }
}
