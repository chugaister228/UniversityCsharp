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
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(s => s.SaleId);

            builder.Property(s => s.Date)
                .HasDefaultValueSql("GETDATE()");

            builder.HasOne(s => s.Product)
                .WithMany(p => p.Sales)
                .HasForeignKey(s => s.ProductId);

            builder.HasOne(s => s.Customer)
                .WithMany(p => p.Sales)
                .HasForeignKey(s => s.CustomerId);

            builder.HasOne(s => s.Store)
                .WithMany(p => p.Sales)
                .HasForeignKey(s => s.StoreId);

            new FakeSaleSeeding().Seed(builder);
        }
    }
}
