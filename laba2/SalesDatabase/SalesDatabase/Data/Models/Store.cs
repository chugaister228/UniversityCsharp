﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Data.Models
{
    public class Store
    {
        public int StoreId { get; set; }

        public string? Name { get; set; }

        //one to many
        public ICollection<Sale>? Sales { get; set; }
    }
}
