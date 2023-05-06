using Microsoft.EntityFrameworkCore;
using HospitalDatabaseDAL.Data.Models;
using HospitalDatabaseDAL.Configuration;

namespace HospitalDatabaseDAL.Data
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
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DiagnoseConfiguration());
            modelBuilder.ApplyConfiguration(new MedicamentConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new PatientMedicamentConfiguration());
            modelBuilder.ApplyConfiguration(new VisitationConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=HospitalDatabase;Trusted_Connection=True;TrustServerCertificate=True;", b => b.MigrationsAssembly("HospitalWeb"));
            }
        }
    }
}
