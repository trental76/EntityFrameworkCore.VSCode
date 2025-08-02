using Microsoft.EntityFrameworkCore;
using EntityFrameworkCoreVSCore.Domain;
using Microsoft.Extensions.Logging;

namespace EntityFrameworkVSCode.Data;

public class FootballLeageDbContext : DbContext
{
    public DbSet<Team> Teams { get; set; }
    public DbSet<Coach> Coaches { get; set; }
    public DbSet<League> Leagues { get; set; }
    public DbSet<Match> Matches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // SQL Server 
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=FootballLeague;Encrypt=False;")
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors();

        // SQLite
        // optionsBuilder.UseSqlite($"Data Source=FootballLeague.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(FootballLeageDbContext).Assembly);
    }
}