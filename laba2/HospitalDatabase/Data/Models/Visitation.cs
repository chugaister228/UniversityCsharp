using System.ComponentModel.DataAnnotations;

namespace HospitalDatabase.Data.Models
{
    public class Visitation
    {
        public int VisitationId { get; set; }

        public DateOnly Date { get; set; }

        [MaxLength(250)]
        public string? Comments { get; set; }

        public Patient? Patient { get; set; }

        public Doctor? Doctor { get; set; }
    }
}
