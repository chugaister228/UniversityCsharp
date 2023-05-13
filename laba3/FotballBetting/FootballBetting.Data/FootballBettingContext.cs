using FootballBetting.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

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
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
