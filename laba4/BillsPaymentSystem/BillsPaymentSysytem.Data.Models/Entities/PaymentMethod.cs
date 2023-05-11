using BillsPaymentSysytem.Data.Models.Entities;
using BillsPaymentSysytem.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BillsPaymentSysytem.Data.Models
{
    public class PaymentMethod : BaseEntity
    {
        public PaymentMethodType Type { get; set; }
        public User User { get; set; } = null!;
        public Guid UserId { get; set; }
        public BankAccount BankAccount { get; set; } = null!;
        public Guid BankAccountId { get; set; }
        public CreditCard CreditCard { get; set; } = null!; 
        public Guid CreditCardId { get; set; }
    }
}
