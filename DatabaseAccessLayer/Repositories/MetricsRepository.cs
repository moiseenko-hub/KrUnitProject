using DatabaseAccessLayer.Models;

namespace DatabaseAccessLayer.Repositories;

public class MetricsRepository : BaseRepository<MetricsData>
{
    public MetricsRepository(KarinaDbContext dbContext) : base(dbContext) { }
}