using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentDatabase.Data.Models;
using StudentDatabase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentDatabase.Seeding
{
    public class CourseSeeder : ISeeder<Course>
    {
        private static readonly List<Course> cources = new()
        {
            new Course
            {
                CourseId = 1,
                Name = "Math",
                Description = "Math studing",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                Price = 1000
            },

            new Course
            {
                CourseId = 2,
                Name = "Programming",
                Description = "Programming studing",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                Price = 2000
            }
        };

        public void Seed(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(cources);
        }
    }
}
