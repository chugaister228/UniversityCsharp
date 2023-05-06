using System.ComponentModel.DataAnnotations;

namespace HospitalDatabaseDAL.Data.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Address { get; set; }

        public string? Email { get; set; }

        public bool HasInsurance { get; set; }

        //one to many
        public ICollection<Diagnose>? Diagnoses { get; set; }

        //one to many
        public ICollection<PatientMedicament>? Prescriptions { get; set; }

        //one to many
        public ICollection<Visitation>? Visitations { get; set; }
    }
}
