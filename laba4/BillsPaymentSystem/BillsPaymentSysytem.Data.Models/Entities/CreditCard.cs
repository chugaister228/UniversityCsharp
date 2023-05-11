using BillsPaymentSysytem.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsPaymentSysytem.Data.Models
{
    public class CreditCard : BaseEntity
    {
        public decimal Limit { get; set; }
        public decimal MoneyOwed { get; set; }
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Relationships beetwen tables: One-to-One 
        /// </summary>
        public PaymentMethod? PaymentMethod { get; set; }
    }
}
