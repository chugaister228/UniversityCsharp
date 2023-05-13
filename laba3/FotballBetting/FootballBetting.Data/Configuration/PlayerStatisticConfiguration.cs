using FootballBetting.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FootballBetting.Data.Configuration
{
    public class PlayerStatisticConfiguration : IEntityTypeConfiguration<PlayerStatistic>
    {
        public void Configure(EntityTypeBuilder<PlayerStatistic> builder)
        {
            builder.HasOne(ps => ps.Game)
                   .WithMany(g => g.PlayerStatistics)
                   .HasForeignKey(ps => ps.GameId);

            builder.HasOne(ps => ps.Player)
                   .WithMany(p => p.PlayerStatistics)
                   .HasForeignKey(ps => ps.PlayerId);

            builder.Property(ps => ps.ScoredGoals)
                   .IsRequired();

            builder.Property(ps => ps.Assists)
                   .IsRequired();

            builder.Property(ps => ps.MinutesPlayed)
                   .IsRequired();
        }
    }
}
