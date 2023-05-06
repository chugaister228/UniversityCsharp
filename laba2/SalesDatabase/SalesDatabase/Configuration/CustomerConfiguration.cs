using SalesDatabase.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDatabase.Seeding;

namespace SalesDatabase.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.CustomerId);

            builder.Property(c => c.Name)
                .HasMaxLength(100)
                .IsUnicode(true);

            builder.Property(c => c.Email)
                .HasMaxLength(80)
                .IsUnicode(false);

            builder.Property(c => c.CreditCardNumber);

            new FakeCustomerSeeder().Seed(builder);
        }
    }
}
