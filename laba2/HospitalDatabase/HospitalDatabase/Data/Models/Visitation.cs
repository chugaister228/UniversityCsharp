using HospitalDatabase.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace HospitalDatabaseDAL.Data.Models
{
    public class Visitation
    {
        public int VisitationId { get; set; }

        public DateTime Date { get; set; }

        public string? Comments { get; set; }

        public int PatientId { get; set; }

        public int DoctorId { get; set; }

        //many to one
        public Patient? Patient { get; set; }

        //many to one
        public Doctor? Doctor { get; set; }
    }
}
