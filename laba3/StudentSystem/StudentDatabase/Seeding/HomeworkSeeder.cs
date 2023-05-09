using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentDatabase.Data.Models;
using StudentDatabase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudentDatabase.Data.Enums.ContentTypeEnum;

namespace StudentDatabase.Seeding
{
    public class HomeworkSeeder : ISeeder<Homework>
    {
        private static readonly List<Homework> homeworks = new()
        {
            new Homework
            {
                HomeworkId = 1,
                Content = "Task",
                ContentType = ContentType.Pdf,
                SubmissionTime = DateTime.Now,
                CourseId = 1,
                StudentId = 1
            },

            new Homework
            {
                HomeworkId = 2,
                Content = "Task",
                ContentType = ContentType.Aplication,
                SubmissionTime = DateTime.Now,
                CourseId = 2,
                StudentId = 1
            }
        };

        public void Seed(EntityTypeBuilder<Homework> builder)
        {
            builder.HasData(homeworks);
        }
    }
}
