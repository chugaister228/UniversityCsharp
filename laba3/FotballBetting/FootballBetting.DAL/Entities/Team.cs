namespace FootballBetting.DAL.Entities
{
    public class Team : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string LogoUrl { get; set; } = null!;
        public string Initials { get; set; } = null!;
        public decimal Budget { get; set; }
        public Guid PrimaryKitColorId { get; set; }
        public Guid SecondaryKitColorId { get; set; }
        public Guid TownId { get; set; }
        public Color PrimaryKitColor { get; set; } = null!;
        public Color SecondaryKitColor { get; set; } = null!;
        public Town Town { get; set; } = null!;
        public ICollection<Game>? HomeGames { get; set; }
        public ICollection<Game>? AwayGames { get; set; }
        public ICollection<Player>? Players { get; set; }
    }
}
