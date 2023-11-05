using Microsoft.EntityFrameworkCore;

namespace Taste.Models
{
  public class TasteContext : DbContext
  {
    public DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<TreatFlavor> TreatFlavors { get; set; }
    public TasteContext(DbContextOptions options) : base(options) { }
  }
}