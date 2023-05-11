namespace HospitalDatabase.DAL.Entities
{
    public class Diagnose : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Comments { get; set; } = null!;
        public Guid PatientId { get; set; }
        public Patient Patient { get; set; } = null!;
    }
}
