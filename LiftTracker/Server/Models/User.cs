namespace LiftTracker.Server.Models
{
  public class User
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public List<Session> Sessions { get; set; } = new List<Session>();
    public List<Plan> Plans { get; set; } = new List<Plan>();
  }
}
