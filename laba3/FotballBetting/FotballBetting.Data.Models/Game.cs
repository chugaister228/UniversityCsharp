using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotballBetting.Data.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
        public DateTime DateTime { get; set; }
        public int HomeTeamBetRate { get; set; }
        public int AwayTeamBetRate { get; set; }
        public int DrawBetRate { get; set; }
        public string? Result { get; set; }

        //many to one
        public Team? HomeTeam { get; set; }
        public Team? AwayTeam { get; set; }

        //one to many
        public ICollection<Bet>? Bets { get; set; }
        public ICollection<PlayerStatistic>? PlayerStatistics { get; set; }
    }
}
