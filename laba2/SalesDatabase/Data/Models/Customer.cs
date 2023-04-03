using System.ComponentModel.DataAnnotations;

namespace HospitalDatabase.Data.Models.Sales
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength (80)]
        public string? Email { get; set; }

        public string? CreditCardNumber { get; set; }
    }
}
