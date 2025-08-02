using EntityFrameworkCoreVSCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal class LeagueConfiguration : IEntityTypeConfiguration<League>
{
    public void Configure(EntityTypeBuilder<League> builder)
    {
        builder.HasData(
        new League { Id = 1, Name = "Premier League", CreatedDate = new DateTime(2025, 1, 25) },
        new League { Id = 2, Name = "II-er Liga", CreatedDate = new DateTime(2025, 1, 25) });
    }
}