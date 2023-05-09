using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentDatabase.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase.Configuration
{
    public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(sc => sc.StudentId);

            builder.HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCources)
                .HasForeignKey(s => s.StudentId);

            builder.HasKey(sc => sc.CourseId);

            builder.HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCources)
                .HasForeignKey(sc => sc.CourseId);
        }
    }
}
