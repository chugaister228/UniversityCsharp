namespace SalesDatabase.DAL.Entities
{
    public abstract class BaseEntity
    {
        public Guid ID { get; set; }
        public BaseEntity() { ID = Guid.NewGuid(); }
    }
}
