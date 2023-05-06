using System.ComponentModel.DataAnnotations;

namespace HospitalDatabaseDAL.Data.Models
{
    public class Medicament
    {
        public int MedicamentId { get; set; }

        public string? Name { get; set; }

        //one to many
        public ICollection<PatientMedicament>? Prescriptions { get; set; }
    }
}
