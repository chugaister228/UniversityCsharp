using HospitalDatabaseDAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabaseDAL.Configuration
{
    public class VisitationConfiguration : IEntityTypeConfiguration<Visitation>
    {
        public void Configure(EntityTypeBuilder<Visitation> builder)
        {
            builder.HasKey(v => v.VisitationId);

            builder.Property(v => v.Date);

            builder.Property(v => v.Comments)
                .HasMaxLength(250)
                .IsUnicode(true);

            builder.HasOne(v => v.Patient)
                .WithMany(p => p.Visitations)
                .HasForeignKey(v => v.PatientId);

            builder.HasOne(v => v.Doctor)
                .WithMany(d => d.Visitations)
                .HasForeignKey(v => v.DoctorId);
        }
    }
}
