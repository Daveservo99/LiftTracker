using LiftTracker.Server.Models;

namespace LiftTracker.Server.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
            
    }

    public DbSet<Exercise> Exercises { get; set; }
  }
}