namespace FootballBetting.DAL.Entities
{
    public class Player : BaseEntity
    {
        public string Name { get; set; } = null!;
        public int SquadNumber { get; set; }
        public Guid TeamId { get; set; }
        public Guid PositionId { get; set; }
        public bool IsInjured { get; set; }
        public Team Team { get; set; } = null!;
        public Position Position { get; set; } = null!;
        public ICollection<PlayerStatistic> PlayerStatistics { get; set; } = null!;
    }
}
