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
    public class CreditCardConfiguration : IEntityTypeConfiguration<CreditCard>
    {
        public void Configure(EntityTypeBuilder<CreditCard> builder)
        {
            builder.Property(c => c.Limit)
                .IsRequired();

            builder.Property(c => c.MoneyOwed)
                .IsRequired();

            builder.Property(c => c.ExpirationDate)
                .IsRequired();
        }
    }
}
