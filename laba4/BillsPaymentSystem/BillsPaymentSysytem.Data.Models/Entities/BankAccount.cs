using BillsPaymentSysytem.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsPaymentSysytem.Data.Models
{
    public class BankAccount : BaseEntity
    {
        public decimal Balance { get; set; }
        public string BankName { get; set; } = string.Empty;
        public string? SwiftCode { get; set; }
        
        /// <summary>
        /// Relationships beetwen tables: One-to-One 
        /// </summary>
        public PaymentMethod? PaymentMethod { get; set; }
    }
}
