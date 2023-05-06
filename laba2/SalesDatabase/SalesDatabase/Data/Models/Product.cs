﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Data.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string? Name { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public string? Description { get; set; }

        //one to many
        public ICollection<Sale>? Sales { get; set; }
    }
}
