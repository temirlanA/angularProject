using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace angularProject.Entities
{
    public partial class GameContext : DbContext
    {
        public GameContext()
        {
        }

        public GameContext(DbContextOptions<GameContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MatchT> MatchT { get; set; }
        public virtual DbSet<PlayerT> PlayerT { get; set; }
        public virtual DbSet<TeamPlayersT> TeamPlayersT { get; set; }
        public virtual DbSet<TeamT> TeamT { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnectionString"]);
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MatchT>(entity =>
            {
                entity.HasKey(e => e.MatchId);

                entity.ToTable("match_t");

                entity.Property(e => e.MatchId)
                    .HasColumnName("matchId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.MacthName)
                    .HasColumnName("macthName")
                    .HasMaxLength(50);

                entity.Property(e => e.TeamA)
                    .HasColumnName("teamA")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.TeamB)
                    .HasColumnName("teamB")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.TeamANavigation)
                    .WithMany(p => p.MatchTTeamANavigation)
                    .HasForeignKey(d => d.TeamA)
                    .HasConstraintName("FK_match_t_team_t");

                entity.HasOne(d => d.TeamBNavigation)
                    .WithMany(p => p.MatchTTeamBNavigation)
                    .HasForeignKey(d => d.TeamB)
                    .HasConstraintName("FK_match_t_team_t1");
            });

            modelBuilder.Entity<PlayerT>(entity =>
            {
                entity.HasKey(e => e.PlayerId)
                    .HasName("PK_Player_t_1");

                entity.ToTable("Player_t");

                entity.Property(e => e.PlayerId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TeamPlayersT>(entity =>
            {
                entity.HasKey(e => e.TeamPlayersId);

                entity.ToTable("teamPlayers_t");

                entity.Property(e => e.TeamPlayersId)
                    .HasColumnName("teamPlayersId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Player1).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Player2).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Player3).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Player4).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Player5).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Player6).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Player7).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Player8).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Player9).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Player1Navigation)
                    .WithMany(p => p.TeamPlayersTPlayer1Navigation)
                    .HasForeignKey(d => d.Player1)
                    .HasConstraintName("FK_teamPlayers_t_Player_t");

                entity.HasOne(d => d.Player2Navigation)
                    .WithMany(p => p.TeamPlayersTPlayer2Navigation)
                    .HasForeignKey(d => d.Player2)
                    .HasConstraintName("FK_teamPlayers_t_Player_t1");

                entity.HasOne(d => d.Player3Navigation)
                    .WithMany(p => p.TeamPlayersTPlayer3Navigation)
                    .HasForeignKey(d => d.Player3)
                    .HasConstraintName("FK_teamPlayers_t_Player_t2");

                entity.HasOne(d => d.Player4Navigation)
                    .WithMany(p => p.TeamPlayersTPlayer4Navigation)
                    .HasForeignKey(d => d.Player4)
                    .HasConstraintName("FK_teamPlayers_t_Player_t3");

                entity.HasOne(d => d.Player5Navigation)
                    .WithMany(p => p.TeamPlayersTPlayer5Navigation)
                    .HasForeignKey(d => d.Player5)
                    .HasConstraintName("FK_teamPlayers_t_Player_t4");

                entity.HasOne(d => d.Player6Navigation)
                    .WithMany(p => p.TeamPlayersTPlayer6Navigation)
                    .HasForeignKey(d => d.Player6)
                    .HasConstraintName("FK_teamPlayers_t_Player_t5");

                entity.HasOne(d => d.Player7Navigation)
                    .WithMany(p => p.TeamPlayersTPlayer7Navigation)
                    .HasForeignKey(d => d.Player7)
                    .HasConstraintName("FK_teamPlayers_t_Player_t6");

                entity.HasOne(d => d.Player8Navigation)
                    .WithMany(p => p.TeamPlayersTPlayer8Navigation)
                    .HasForeignKey(d => d.Player8)
                    .HasConstraintName("FK_teamPlayers_t_Player_t7");

                entity.HasOne(d => d.Player9Navigation)
                    .WithMany(p => p.TeamPlayersTPlayer9Navigation)
                    .HasForeignKey(d => d.Player9)
                    .HasConstraintName("FK_teamPlayers_t_Player_t8");
            });

            modelBuilder.Entity<TeamT>(entity =>
            {
                entity.HasKey(e => e.TeamId);

                entity.ToTable("team_t");

                entity.Property(e => e.TeamId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TeamName)
                    .HasColumnName("teamName")
                    .HasMaxLength(50);

                entity.Property(e => e.TeamPlayers).HasColumnName("teamPlayers");

                entity.HasOne(d => d.TeamPlayersNavigation)
                    .WithMany(p => p.TeamT)
                    .HasForeignKey(d => d.TeamPlayers)
                    .HasConstraintName("FK_team_t_teamPlayers_t");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
