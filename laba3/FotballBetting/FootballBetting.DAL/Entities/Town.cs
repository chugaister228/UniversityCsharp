namespace FootballBetting.DAL.Entities
{
    public class Town : BaseEntity
    {
        public string Name { get; set; } = null!;
        public Guid CountryId { get; set; }
        public Country Country { get; set; } = null!;
        public ICollection<Team> Teams { get; set; } = null!;
    }
}
