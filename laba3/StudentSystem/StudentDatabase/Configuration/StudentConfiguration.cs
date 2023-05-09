using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentDatabase.Data.Models;
using StudentDatabase.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.StudentId);

            builder.Property(s => s.Name)
                .IsRequired(true)
                .HasMaxLength(100)
                .IsUnicode(true);

            builder.Property(s => s.PhoneNumber)
                .IsRequired(false)
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(s => s.RegisteredOn)
                .IsRequired(true);

            builder.Property(s => s.Birthday);

            new StudentSeeder().Seed(builder);
        }
    }
}
