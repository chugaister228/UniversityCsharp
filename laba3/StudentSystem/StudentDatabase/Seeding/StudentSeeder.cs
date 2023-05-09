using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentDatabase.Data.Models;
using StudentDatabase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase.Seeding
{
    public class StudentSeeder : ISeeder<Student>
    {
        private static readonly List<Student> students = new()
        {
            new Student
            {
                StudentId = 1,
                Name = "Oleh",
                PhoneNumber = "+123456789",
                RegisteredOn = DateTime.Now,
                Birthday = DateTime.Now
            },

            new Student
            {
                StudentId = 2,
                Name = "Stepan",
                PhoneNumber = "+123456789",
                RegisteredOn = DateTime.Now,
                Birthday = DateTime.Now
            }
        };

        public void Seed(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(students);
        }
    }
}
