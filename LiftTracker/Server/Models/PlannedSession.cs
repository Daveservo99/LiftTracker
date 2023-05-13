namespace LiftTracker.Server.Models
{
  public class PlannedSession
  {
    public int Id { get; set; }
    public List<PlannedSet> PlannedSets { get; set; } = new List<PlannedSet>();
  }
}
