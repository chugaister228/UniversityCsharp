using HospitalDatabase.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            Seeding.SeedingInit();

            modelBuilder.Entity<Doctor>().HasData(Seeding.Doctors);
        }
    }
}
