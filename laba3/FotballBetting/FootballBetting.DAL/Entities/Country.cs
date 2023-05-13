namespace FootballBetting.DAL.Entities
{
    public class Country : BaseEntity
    {
        public string Name { get; set; } = null!;
        public ICollection<Town> Towns { get; set; } = null!;
    }
}
