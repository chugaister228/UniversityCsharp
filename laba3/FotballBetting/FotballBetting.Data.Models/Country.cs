using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotballBetting.Data.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string? Name { get; set; }

        //one to many
        public ICollection<Town>? Towns { get; set; }
    }
}
