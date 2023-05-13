namespace FootballBetting.DAL.Entities
{
    public class Bet : BaseEntity
    {
        public int Amount { get; set; }
        public string Prediction { get; set; } = null!;
        public DateTime DateTime { get; set; }
        public Guid UserId { get; set; }
        public Guid GameId { get; set; }
        public User User { get; set; } = null!;
        public Game Game { get; set; } = null!;
    }
}
