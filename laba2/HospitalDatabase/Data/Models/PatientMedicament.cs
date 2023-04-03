namespace HospitalDatabase.Data.Models
{
    public class PatientMedicament
    {
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }

        public string? MedicamentId { get; set; }
        public Medicament? Medicament { get; set; }
    }
}
