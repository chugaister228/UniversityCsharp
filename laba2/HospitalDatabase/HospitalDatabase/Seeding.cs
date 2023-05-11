using HospitalDatabase.DAL.Entities;
using Bogus;

namespace HospitalDatabase.Data
{
    public static class Seeding
    {
        public static List<Doctor> Doctors { get; set; } = new();

        public static void SeedingInit()
        {
            Doctors = new Faker<Doctor>()
                .RuleFor(x => x.Name, f => f.Person.FullName)
                .RuleFor(x => x.Speciality, f => f.Lorem.Word())
                .RuleFor(x => x.Login, f => f.Internet.Password())
                .RuleFor(x => x.Email, f => f.Internet.Email())
                .Generate(10);
        }
    }
}
