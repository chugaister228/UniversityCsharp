using HospitalDatabase.Data.Models.Sales;

namespace SalesDatabase.Data.Models
{
    public class Sale
    {
        public int SaleId { get; set; }

        public DateOnly Date { get; set; }

        public Product? Product { get; set; }

        public Customer? Customer { get; set; }

        public Store? Store { get; set; }
    }
}
