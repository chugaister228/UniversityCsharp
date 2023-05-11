using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDatabase.DAL.Entities;

namespace SalesDatabase.Data.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(c => c.Name)
                .HasMaxLength(100)
                .IsUnicode(true);

            builder.Property(c => c.Email)
                .HasMaxLength(80)
                .IsUnicode(false);

            builder.Property(c => c.CreditCardNumber);
        }
    }
}
