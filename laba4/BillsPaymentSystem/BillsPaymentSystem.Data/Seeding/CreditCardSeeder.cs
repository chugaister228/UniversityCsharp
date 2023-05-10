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
    public class CreditCardSeeder : ISeeder<CreditCard>
    {
        private static readonly List<CreditCard> creditCards = new()
        {
            new CreditCard
            {
                CreditCardId = 1,
                ExpirationDate = DateTime.Now,
                Limit = 10000,
                MoneyOwed = 100
            },

            new CreditCard
            {
                CreditCardId = 2,
                ExpirationDate = DateTime.Now,
                Limit = 10000,
                MoneyOwed = 200
            }
        };

        public void Seed(EntityTypeBuilder<CreditCard> builder)
        {
            builder.HasData(creditCards);
        }
    }
}
