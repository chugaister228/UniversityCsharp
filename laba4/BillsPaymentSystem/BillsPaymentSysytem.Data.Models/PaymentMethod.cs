using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static BillsPaymentSysytem.Data.Models.Enums.PaymentMethodTypeEnum;

namespace BillsPaymentSysytem.Data.Models
{
    public class PaymentMethod
    {
        public int PaymentMethodId { get; set; }

        public PaymentMethodType Type { get; set; }

        public int UserId { get; set; }

        public int BankAccountId { get; set; }

        public int CreditCardId { get; set; }

        //many to one
        public User? User { get; set; }

        //one to one
        public BankAccount? BankAccount { get; set; }

        public CreditCard? CreditCard { get; set; } 
    }
}
