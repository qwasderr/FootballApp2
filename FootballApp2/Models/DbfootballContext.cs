using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;

namespace FootballApp2.Models;

public partial class DbfootballContext : DbContext
{
    public DbfootballContext()
    {
    }

    public DbfootballContext(DbContextOptions<DbfootballContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
     //=> optionsBuilder.UseSqlServer("Server= DESKTOP-JG8P8MC\\SQLEXPRESS;\nDatabase=DBFootball; Trusted_Connection=True; TrustServerCertificate=True");
       => optionsBuilder.UseSqlServer(builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING"))*/

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PlayerUrl).HasColumnName("PlayerURl");
            entity.Property(e => e.Position).HasMaxLength(50);

            entity.HasOne(d => d.Team).WithMany(p => p.Players)
                .HasForeignKey(d => d.TeamId)
                .HasConstraintName("FK_Players_Teams");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.Property(e => e.DivName).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Country).WithMany(p => p.Teams)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Teams_Countries");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
