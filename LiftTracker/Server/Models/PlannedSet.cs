namespace LiftTracker.Server.Models
{
  public class PlannedSet
  {
    public int Id { get; set; }
    public Exercise Exercise { get; set; }
    public int TargetMinRep { get; set; }
    public int TargetMaxRep { get; set; }
  }
}
