using BillsPaymentSysytem.Data.Models;
using BillsPaymentSysytem.Data.Models.Entities;
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
            builder
                .HasIndex(pm => pm.BankAccountId).IsUnique();

            builder
                .HasIndex(pm => pm.CreditCardId).IsUnique();

            builder
                .HasOne(pm => pm.BankAccount)
                .WithOne(b => b.PaymentMethod)
                .HasForeignKey<PaymentMethod>(pm => pm.BankAccountId);

            builder
                .HasOne(pm => pm.CreditCard)
                .WithOne(c => c.PaymentMethod)
                .HasForeignKey<PaymentMethod>(pm => pm.CreditCardId);

            builder
                .HasOne(pm => pm.User)
                .WithMany(u => u.PaymentMethods)
                .HasForeignKey(pm => pm.UserId);
        }
    }
}
