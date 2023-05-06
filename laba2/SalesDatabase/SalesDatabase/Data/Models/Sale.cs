using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Data.Models
{
    public class Sale
    {
        public int SaleId { get; set; }

        public DateTime Date { get; set; }

        public int CustomerId { get; set; }

        public int ProductId { get; set; }

        public int StoreId { get; set; }

        //many to one
        public Customer? Customer { get; set; }

        //many to one
        public Product? Product { get; set; }

        //many to one
        public Store? Store { get; set; }
    }
}
