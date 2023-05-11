using System;
using System.Collections.Generic;
namespace SalesDatabase.DAL.Entities
{
    public class Sale : BaseEntity
    {
        public DateTime Date { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
        public Guid StoreId { get; set; }
        public Customer Customer { get; set; } = null!;
        public Product Product { get; set; } = null!;
        public Store Store { get; set; } = null!;
    }
}
