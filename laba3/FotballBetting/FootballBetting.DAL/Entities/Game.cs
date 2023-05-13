namespace FootballBetting.DAL.Entities
{
    public class Game : BaseEntity
    {
        public Guid HomeTeamId { get; set; }
        public Guid AwayTeamId { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
        public DateTime DateTime { get; set; }
        public int HomeTeamBetRate { get; set; }
        public int AwayTeamBetRate { get; set; }
        public int DrawBetRate { get; set; }
        public string Result { get; set; } = null!;
        public Team HomeTeam { get; set; } = null!;
        public Team AwayTeam { get; set; } = null!;
        public ICollection<Bet> Bets { get; set; } = null!;
        public ICollection<PlayerStatistic> PlayerStatistics { get; set; } = null!;
    }
}
