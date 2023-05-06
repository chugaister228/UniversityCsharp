namespace HospitalDatabaseDAL.Data.Models
{
    public class PatientMedicament
    {
        public int PatientId { get; set; }

        //many to one
        public Patient? Patient { get; set; }


        public int MedicamentId { get; set; }

        //many to one
        public Medicament? Medicament { get; set; }
    }
}
