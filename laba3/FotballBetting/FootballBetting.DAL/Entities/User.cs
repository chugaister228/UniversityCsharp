namespace FootballBetting.DAL.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal Balance { get; set; }
        public ICollection<Bet> Bets { get; set; } = null!;
    }
}
