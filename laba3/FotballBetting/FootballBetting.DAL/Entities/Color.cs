namespace FootballBetting.DAL.Entities
{
    public class Color : BaseEntity
    {
        public string Name { get; set; } = null!;
        public ICollection<Team> PrimaryKitTeams { get; set; } = null!;
        public ICollection<Team> SecondaryKitTeams { get; set; } = null!;
    }
}
