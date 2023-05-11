using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SalesDatabase.DAL.Entities;

namespace SalesDatabase.Data.Configuration
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
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
        }
    }
}
