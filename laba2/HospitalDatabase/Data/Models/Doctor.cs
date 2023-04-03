using System.ComponentModel.DataAnnotations;

namespace HospitalDatabase.Data.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(100)]
        public string? Speciality { get; set; }
    }
}
