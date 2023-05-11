namespace HospitalDatabase.DAL.Entities
{
    public class PatientMedicament : BaseEntity
    {
        public Guid PatientId { get; set; }
        public Patient Patient { get; set; } = null!;
        public Guid MedicamentId { get; set; }
        public Medicament Medicament { get; set; } = null!;
    }
}
