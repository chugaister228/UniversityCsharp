using Microsoft.EntityFrameworkCore;
using HospitalDatabase.Data.Models;

namespace HospitalDatabase.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options) { }

        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<Visitation> Visitations => Set<Visitation>();
        public DbSet<Diagnose> Diagnose => Set<Diagnose>();
        public DbSet<Medicament> Medics => Set<Medicament>();
        public DbSet<PatientMedicament> PatientMedicaments => Set<PatientMedicament>();
        public DbSet<Doctor> Doctors => Set<Doctor>();
    }
}
