using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsPaymentSysytem.Data.Models
{
    public class CreditCard
    {
        public int CreditCardId { get; set; }

        public int Limit { get; set; }

        public int MoneyOwed { get; set; }

        public DateTime ExpirationDate { get; set; }

        //one to one
        public PaymentMethod? PaymentMethod { get; set; }
    }
}
