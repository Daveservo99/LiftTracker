namespace LiftTracker.Server.Models
{
  public class Session
  {
    public int Id { get; set; }
    public User User { get; set; }
    public List<Set> Sets { get; set; } = new List<Set>();
    public DateTime DateTime { get; set; } = DateTime.Now;
    public string Notes { get; set; } = string.Empty;
  }
}
