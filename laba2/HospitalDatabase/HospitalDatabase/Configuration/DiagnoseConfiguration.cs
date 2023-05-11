using HospitalDatabase.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalDatabaseDAL.Configuration
{
    public class DiagnoseConfiguration : IEntityTypeConfiguration<Diagnose>
    {
        public void Configure(EntityTypeBuilder<Diagnose> builder)
        {
            builder.Property(d => d.Name)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(d => d.Comments)
                .HasMaxLength(250)
                .IsUnicode(true);

            builder.HasOne(d => d.Patient)
                .WithMany(p => p.Diagnoses)
                .HasForeignKey(d => d.PatientId);
        }
    }
}
