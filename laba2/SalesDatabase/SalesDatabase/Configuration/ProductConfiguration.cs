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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);

            builder.Property(p => p.Name) 
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(p => p.Quantity);

            builder.Property(p => p.Price);

            builder.Property(p => p.Description)
                .HasMaxLength(250)
                .HasDefaultValue("No description");

            new FakeProductSeeder().Seed(builder);
        }
    }
}
