using FootballBetting.Configuration;
using FotballBetting.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetting.Data
{
    public class FootballBettingContext : DbContext
    {
        public FootballBettingContext(DbContextOptions<FootballBettingContext> options) : base(options) { }

        public DbSet<Bet> Bets => Set<Bet>();

        public DbSet<Color> Colors => Set<Color>();

        public DbSet<Country> Countries => Set<Country>();

        public DbSet<Game> Games => Set<Game>();

        public DbSet<Player> Players => Set<Player>();

        public DbSet<PlayerStatistic> PlayerStatistics => Set<PlayerStatistic>();

        public DbSet<Position> Positions => Set<Position>();

        public DbSet<Team> Teams => Set<Team>();

        public DbSet<Town> Towns => Set<Town>();

        public DbSet<User> Users => Set<User>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BetConfiguration());
            modelBuilder.ApplyConfiguration(new ColorConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new GameConfiguration());
            modelBuilder.ApplyConfiguration(new PlayerConfiguration());
            modelBuilder.ApplyConfiguration(new PlayerStatisticConfiguration());
            modelBuilder.ApplyConfiguration(new PositionConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
            modelBuilder.ApplyConfiguration(new TownConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=FootballBettingDatabase;Trusted_Connection=True;TrustServerCertificate=True;", b => b.MigrationsAssembly("FootballBettingWeb"));
            }
        }
    }
}
