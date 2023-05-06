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
    public class DiagnoseConfiguration : IEntityTypeConfiguration<Diagnose>
    {
        public void Configure(EntityTypeBuilder<Diagnose> builder)
        {
            builder.HasKey(d => d.DiagnoseId);

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
