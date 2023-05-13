namespace FootballBetting.DAL.Entities
{
    public class PlayerStatistic : BaseEntity
    {
        public Guid GameId { get; set; }
        public Guid PlayerId { get; set; }
        public int ScoredGoals { get; set; }
        public int Assists { get; set; }
        public int MinutesPlayed { get; set; }
        public Game Game { get; set; } = null!;
        public Player Player { get; set; } = null!;
    }
}
