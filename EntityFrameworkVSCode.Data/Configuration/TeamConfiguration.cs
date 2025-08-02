using EntityFrameworkCoreVSCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal class TeamConfiguration : IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.HasIndex(e => e.Name).IsUnique();
        builder.HasMany(m => m.HomeMatches)
            .WithOne(q => q.HomeTeam)
            .HasForeignKey(q => q.HomeTeamId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(m => m.AwayMatches)
            .WithOne(q => q.AwayTeam)
            .HasForeignKey(q => q.AwayTeamId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(
            new Team { Id = 1, Name = "Tivoli gardens F.C.", CreatedDate = new DateTime(2025, 1, 25), LeagueId = 1, CoachId = 1 },
            new Team { Id = 2, Name = "Waterhouse F.C.", CreatedDate = new DateTime(2025, 1, 25), LeagueId = 1, CoachId = 2 },
            new Team { Id = 3, Name = "Humble Lions F.C.", CreatedDate = new DateTime(2025, 1, 25), LeagueId = 1, CoachId = 3 });
    }
}