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
    public class HomeworkConfiguration : IEntityTypeConfiguration<Homework>
    {
        public void Configure(EntityTypeBuilder<Homework> builder)
        {
            builder.Property(h => h.Content)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(h => h.ContentType)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(h => h.SubmissionTime)
                .IsRequired();

            builder.HasOne(h => h.Student)
                .WithMany(s => s.Homeworks)
                .HasForeignKey(s => s.StudentId);

            builder.HasOne(h => h.Course)
                .WithMany(c => c.Homeworks)
                .HasForeignKey(h => h.CourseId);
        }
    }
}
