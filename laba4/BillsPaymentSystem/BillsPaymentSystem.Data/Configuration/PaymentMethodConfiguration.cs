using BillsPaymentSystem.Data.Seeding;
using BillsPaymentSysytem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsPaymentSystem.Data.Configuration
{
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasKey(pm => pm.PaymentMethodId);

            builder.Property(pm => pm.Type)
                .IsRequired()
                .HasConversion<string>();

            builder.HasIndex(pm => pm.BankAccountId)
                .IsUnique();

            builder.HasIndex(pm => pm.CreditCardId)
                .IsUnique();

            builder.HasOne(pm => pm.BankAccount)
                .WithOne(b => b.PaymentMethod)
                .HasForeignKey<PaymentMethod>(pm => pm.BankAccountId);

            builder.HasOne(pm => pm.CreditCard)
                .WithOne(c => c.PaymentMethod)
                .HasForeignKey<PaymentMethod>(pm => pm.CreditCardId);

            builder.HasOne(pm => pm.User)
                .WithMany(u => u.PaymentMethods)
                .HasForeignKey(pm => pm.UserId);

            //builder.HasCheckConstraint("CK_PaymentMethods",
            //       @"((BankAccountId IS NULL AND CreditCardId IS NOT NULL) OR (BankAccountId IS NOT NULL AND CreditCardId IS NULL))");

            new PaymentMethodSeeder().Seed(builder);
        }
    }
}
