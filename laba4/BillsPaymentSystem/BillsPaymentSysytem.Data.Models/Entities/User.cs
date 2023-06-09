﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsPaymentSysytem.Data.Models.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;    
        public string? Email { get; set; }
        public string? Password { get; set; }
        public ICollection<PaymentMethod> PaymentMethods { get; set; } = null!;
    }
}
