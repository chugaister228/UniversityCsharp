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
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(c => c.Name)
                .IsRequired(true)
                .HasMaxLength(80)
                .IsUnicode(true);

            builder.Property(c => c.Description)
                .IsUnicode(true);

            builder.Property(c => c.StartDate)
                .IsRequired(true);

            builder.Property(c => c.EndDate)
                .IsRequired(true);

            builder.Property(c => c.Price)
                .IsRequired(true);
        }
    }
}
