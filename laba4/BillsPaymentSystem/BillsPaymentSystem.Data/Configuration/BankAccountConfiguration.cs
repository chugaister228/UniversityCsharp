using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillsPaymentSysytem.Data.Models;
using BillsPaymentSysytem.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BillsPaymentSystem.Data.Configuration
{
    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.Property(b => b.BankName)
                .HasMaxLength(50).IsUnicode(true);

            builder.Property(b => b.SwiftCode)
                .HasMaxLength(20).IsUnicode(false);
        }
    }
}
