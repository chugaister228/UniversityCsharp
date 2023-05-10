using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsPaymentSysytem.Data.Models
{
    public class BankAccount
    {
        public int BankAccountId { get; set; }

        public int Balance { get; set; }

        public string? BankName { get; set; }

        public string? SwiftCode { get; set; }

        //one to one
        public PaymentMethod? PaymentMethod { get; set; }
    }
}
