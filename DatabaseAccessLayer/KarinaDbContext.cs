using DatabaseAccessLayer.Configurations;
using DatabaseAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAccessLayer;

public class KarinaDbContext : DbContext
{
    public const string CONNECTION_STRING = "User ID=postgres;Password=root;Host=localhost;Port=5432;Database=KarinaDb;";
    
    // Data
    public DbSet<MetricsData> Metrics { get; set; }
    
    public KarinaDbContext(){}
    public KarinaDbContext(DbContextOptions<KarinaDbContext> option) : base(option) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(CONNECTION_STRING);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new MetricsConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}