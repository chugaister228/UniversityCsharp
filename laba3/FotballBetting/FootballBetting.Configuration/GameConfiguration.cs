using FotballBetting.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetting.Configuration
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(g => g.GameId);

            builder.HasOne(g => g.HomeTeam)
                .WithMany(t => t.HomeGames)
                .HasForeignKey(g => g.HomeTeamId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(g => g.AwayTeam)
                .WithMany(t => t.AwayGames)
                .HasForeignKey(g => g.AwayTeamId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(g => g.HomeTeamGoals);

            builder.Property(g => g.AwayTeamGoals);

            builder.Property(g => g.DateTime);

            builder.Property(g => g.HomeTeamBetRate);

            builder.Property(g => g.AwayTeamBetRate);

            builder.Property(g => g.DrawBetRate);

            builder.Property(g => g.Result)
                .HasMaxLength(10);  
        }
    }
}
