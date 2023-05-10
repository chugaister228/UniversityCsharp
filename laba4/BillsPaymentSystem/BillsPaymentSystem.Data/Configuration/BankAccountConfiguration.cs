using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillsPaymentSystem.Data.Seeding;
using BillsPaymentSysytem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BillsPaymentSystem.Data.Configuration
{
    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.HasKey(b => b.BankAccountId);

            builder.Property(b => b.Balance)
                .IsRequired();

            builder.Property(b => b.BankName)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(b => b.SwiftCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            new BankAccountSeeder().Seed(builder);
        }
    }
}
