namespace SalesDatabase.DAL.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;
        public ICollection<Sale> Sales { get; set; } = null!;
    }
}
