using System.ComponentModel.DataAnnotations;

namespace HospitalDatabaseDAL.Data.Models
{
    public class Diagnose
    {
        public int DiagnoseId { get; set; }

        public string? Name { get; set; }

        public string? Comments { get; set; }

        public int PatientId { get; set; }

        //many to one
        public Patient? Patient { get; set; }
    }
}
