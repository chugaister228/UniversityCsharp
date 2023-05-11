namespace SalesDatabase.DAL.Entities
{
    public class Store : BaseEntity
    {
        public string Name { get; set; } = null!;
        public ICollection<Sale> Sales { get; set; } = null!;
    }
}
