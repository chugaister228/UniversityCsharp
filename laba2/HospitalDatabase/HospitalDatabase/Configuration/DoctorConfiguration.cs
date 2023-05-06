using HospitalDatabase.Data.Models;
using HospitalDatabaseDAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase.Configuration
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(d => d.DoctorId);

            builder.Property(d => d.Name)
                .HasMaxLength(100)
                .IsUnicode(true);

            builder.Property(d => d.Speciality)
                .HasMaxLength(100)
                .IsUnicode(true);
        }
    }
}
