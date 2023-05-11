namespace HospitalDatabase.DAL.Entities
{
    public class Patient : BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool HasInsurance { get; set; }
        public ICollection<Diagnose> Diagnoses { get; set; } = null!;
        public ICollection<PatientMedicament> Prescriptions { get; set; } = null!;
        public ICollection<Visitation> Visitations { get; set; } = null!;
    }
}
