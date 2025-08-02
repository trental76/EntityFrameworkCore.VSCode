using EntityFrameworkCoreVSCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal class CoachConfiguration : IEntityTypeConfiguration<Coach>
{
    public void Configure(EntityTypeBuilder<Coach> builder)
    {
        builder.HasIndex(e => e.Name).IsUnique();
        builder.HasData(
            new Coach { Id = 1, Name = "Donovan Duckie", CreatedDate = new DateTime(2025, 1, 25) },
            new Coach { Id = 2, Name = "Marcel Gayle", CreatedDate = new DateTime(2025, 1, 25) },
            new Coach { Id = 3, Name = "Andrew Price", CreatedDate = new DateTime(2025, 1, 25) });
    }
}