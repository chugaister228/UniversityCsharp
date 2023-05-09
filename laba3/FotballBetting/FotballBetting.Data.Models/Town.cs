using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotballBetting.Data.Models
{
    public class Town
    {
        public int TownId { get; set; }
        public string? Name { get; set; }
        public int CountryId { get; set; }

        //many to one
        public Country? Country { get; set; }

        //one to many
        public ICollection<Team>? Teams { get; set; }
    }
}
