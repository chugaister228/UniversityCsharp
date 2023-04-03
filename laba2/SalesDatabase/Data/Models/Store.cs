using System.ComponentModel.DataAnnotations;

namespace SalesDatabase.Data.Models
{
    public class Store
    {
        public int StoreId { get; set; }

        [MaxLength(80)]
        public string? Name { get; set; }
    }
}
