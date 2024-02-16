using Microsoft.EntityFrameworkCore;

namespace ProjectName.Models
{
  public class ProjectNameContext : DbContext
  {
    public DbSet<Treats> Treats { get; set; }
 
    public ProjectNameContext(DbContextOptions options) : base(options) { }
  }
}