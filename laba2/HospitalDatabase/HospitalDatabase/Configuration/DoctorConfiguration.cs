using HospitalDatabase.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalDatabase.Configuration
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.Property(d => d.Name)
                .HasMaxLength(100)
                .IsUnicode(true);

            builder.Property(d => d.Speciality)
                .HasMaxLength(100)
                .IsUnicode(true);

            builder.Property(d => d.Login)
                .HasMaxLength(20);

            builder.Property(d => d.Email)
                .HasMaxLength(50);
        }
    }
}
