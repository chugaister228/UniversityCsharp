using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotballBetting.Data.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string? Name { get; set; }
        public string? LogoUrl { get; set; } 
        public string? Initials { get; set; }
        public int Budget { get; set; }
        public int PrimaryKitColorId { get; set; }
        public int SecondaryKitColorId { get; set; }
        public int TownId { get; set; }

        //many to one
        public Color? PrimaryKitColor { get; set; }
        public Color? SecondaryKitColor { get; set; }
        public Town? Town { get; set; }

        //one to many
        public ICollection<Game>? HomeGames { get; set; }
        public ICollection<Game>? AwayGames { get; set; }
        public ICollection<Player>? Players { get; set; }
    }
}
