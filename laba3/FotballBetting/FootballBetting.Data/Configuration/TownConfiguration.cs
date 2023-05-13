using FootballBetting.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FootballBetting.Data.Configuration
{
    public class TownConfiguration : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.Property(t => t.Name)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.HasOne(t => t.Country)
                   .WithMany(c => c.Towns)
                   .HasForeignKey(t => t.CountryId);
        }
    }
}
