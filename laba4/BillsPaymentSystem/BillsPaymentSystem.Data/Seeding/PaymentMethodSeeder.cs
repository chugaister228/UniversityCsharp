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
    public class PaymentMethodSeeder : ISeeder<PaymentMethod>
    {
        private static readonly List<PaymentMethod> paymentMethods = new()
        {
            new PaymentMethod
            {
                PaymentMethodId = 1,
                CreditCardId = 1,
                BankAccountId = 1,
                Type = BillsPaymentSysytem.Data.Models.Enums.PaymentMethodTypeEnum.PaymentMethodType.BankAccount,
                UserId = 1
            },

            new PaymentMethod
            {
                PaymentMethodId = 2,
                CreditCardId = 2,
                BankAccountId = 2,
                Type = BillsPaymentSysytem.Data.Models.Enums.PaymentMethodTypeEnum.PaymentMethodType.CreditCard,
                UserId = 1
            }
        };

        public void Seed(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasData(paymentMethods);
        }
    }
}
