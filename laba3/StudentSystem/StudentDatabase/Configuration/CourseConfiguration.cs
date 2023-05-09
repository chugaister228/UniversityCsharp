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
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.CourseId);

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

            new CourseSeeder().Seed(builder);
        }
    }
}
