using HospitalDatabase.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalDatabaseDAL.Configuration
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.Property(p => p.FirstName)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(p => p.LastName)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(p => p.Address)
                .HasMaxLength(250)
                .IsUnicode(true);

            builder.Property(p => p.Address)
                .HasMaxLength(80)
                .IsUnicode(false);

            builder.Property(p => p.HasInsurance);
        }
    }
}
