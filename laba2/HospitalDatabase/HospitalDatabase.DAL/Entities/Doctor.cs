namespace HospitalDatabase.DAL.Entities
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Speciality { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Email { get; set; } = null!;
        public ICollection<Visitation> Visitations { get; set; } = null!;
    }
}
