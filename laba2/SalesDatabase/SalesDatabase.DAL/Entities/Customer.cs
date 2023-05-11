namespace SalesDatabase.DAL.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string CreditCardNumber { get; set; } = null!;
        public ICollection<Sale> Sales { get; set; } = null!;
    }
}
