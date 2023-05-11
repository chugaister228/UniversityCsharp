namespace HospitalDatabase.DAL.Entities
{
    public class Medicament : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<PatientMedicament> Prescriptions { get; set; } = null!;
    }
}
