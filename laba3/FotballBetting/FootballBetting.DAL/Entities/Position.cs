namespace FootballBetting.DAL.Entities
{
    public class Position : BaseEntity
    {
        public int PositionId { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Player> Players { get; set; } = null!;
    }
}
