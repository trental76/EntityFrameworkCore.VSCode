using System;
using System.Collections.Generic;
using EntityFrameworkVSCode.Data.ScaffoldModels;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkVSCode.Data.ScaffoldContext;

public partial class FootballLeagueContext : DbContext
{
    public FootballLeagueContext()
    {
    }

    public FootballLeagueContext(DbContextOptions<FootballLeagueContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Coach> Coaches { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=FootballLeague;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
