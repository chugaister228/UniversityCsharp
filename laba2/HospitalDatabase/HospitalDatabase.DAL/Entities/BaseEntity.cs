namespace HospitalDatabase.DAL.Entities
{
    public class BaseEntity 
    {
        public Guid ID { get; set; }
        public BaseEntity() { ID = Guid.NewGuid(); }
    }
}
