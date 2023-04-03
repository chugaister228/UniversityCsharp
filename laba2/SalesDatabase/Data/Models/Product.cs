using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HospitalDatabase.Data.Models.Sales
{
    public class Product
    {
        public int ProductId { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; }

        public int Quantity { get; set; }

        public string? Price { get; set; }

        [MaxLength(250)]
        [DefaultValue("No description")]
        public string? Description { get; set; }
    }
}
