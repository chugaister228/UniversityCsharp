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
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(p => p.PatientId);

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
