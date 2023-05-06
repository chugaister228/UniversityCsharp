using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDatabase.Data.Models;
using SalesDatabase.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Configuration
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasKey(s => s.StoreId);

            builder.Property(s => s.Name)
                .HasMaxLength(80)
                .IsUnicode(true);

            new FakeStoreSeeding().Seed(builder);
        }
    }
}
