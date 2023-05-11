namespace HospitalDatabase.DAL.Entities
{
    public class Visitation : BaseEntity
    {
        public DateTime Date { get; set; }
        public string Comments { get; set; } = null!;
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public Patient Patient { get; set; } = null!;
        public Doctor Doctor { get; set; } = null!;
    }
}
