using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentSystem.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data.Configuration
{
    public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCources)
                .HasForeignKey(s => s.StudentId);

            builder.HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCources)
                .HasForeignKey(sc => sc.CourseId);
        }
    }
}
