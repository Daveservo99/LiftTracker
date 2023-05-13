using LiftTracker.Server.Models;

namespace LiftTracker.Server.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
            
    }

    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<Plan> Plans { get; set; }
    public DbSet<PlannedSession> PlannedSessions { get; set; }
    public DbSet<PlannedSet> PlannedSets { get; set; }
    public DbSet<Session> Sessions { get; set; }
    public DbSet<Set> Sets { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<WeekTemplate> WeekTemplates { get; set; }
  }
}