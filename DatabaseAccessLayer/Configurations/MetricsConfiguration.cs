using DatabaseAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseAccessLayer.Configurations;

public class MetricsConfiguration : IEntityTypeConfiguration<MetricsData>
{
    public void Configure(EntityTypeBuilder<MetricsData> builder)
    {
        builder
            .HasKey(m => m.Id);
    }
}