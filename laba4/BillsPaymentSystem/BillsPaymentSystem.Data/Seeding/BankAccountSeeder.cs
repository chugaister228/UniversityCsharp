using BillsPaymentSystem.Data.Interfaces;
using BillsPaymentSysytem.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsPaymentSystem.Data.Seeding
{
    internal class BankAccountSeeder : ISeeder<BankAccount>
    {
        private static readonly List<BankAccount> bankAccounts = new()
        {
            new BankAccount
            {
                BankAccountId = 1,
                Balance = 100,
                BankName = "Privat",
                SwiftCode = "kjk12344k1jk"
            },

            new BankAccount
            {
                BankAccountId = 2,
                Balance = 100,
                BankName = "Mono",
                SwiftCode = "ojk14346krjh"
            }
        };

        public void Seed(EntityTypeBuilder<BankAccount> builder)
        {
            builder.HasData(bankAccounts);
        }
    }
}
