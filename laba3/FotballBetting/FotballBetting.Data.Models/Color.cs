using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotballBetting.Data.Models
{
    public class Color
    {
        public int ColorId { get; set; }
        public string? Name { get; set; }

        //one to many
        public ICollection<Team>? PrimaryKitTeams { get; set; }
        public ICollection<Team>? SecondaryKitTeams { get; set; }
    }
}
