﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Data.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? CreditCardNumber { get; set; }

        //one to many
        public ICollection<Sale>? Sales { get; set; }
    }
}
