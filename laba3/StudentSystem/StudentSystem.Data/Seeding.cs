using StudentSystem.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using StudentSystem.DAL.Enums;

namespace StudentSystem.Data
{
    public static class Seeding
    {
        public static List<Course> Courses { get; set; } = new();
        public static List<Homework> Homeworks { get; set; } = new();
        public static List<Resource> Resources { get; set; } = new();
        public static List<Student> Students { get; set; } = new();

        public static void SeedingInit()
        {
            Courses = new Faker<Course>()
                .RuleFor(x => x.Name, f => f.Lorem.Word())
                .RuleFor(x => x.Description, f => f.Lorem.Text())
                .RuleFor(x => x.StartDate, f => f.Date.Future())
                .RuleFor(x => x.EndDate, f => f.Date.Future())
                .RuleFor(x => x.Price, f => f.Random.Decimal())
                .Generate(10);

            Homeworks = new Faker<Homework>()
                .RuleFor(x => x.Content, f => f.Lorem.Text())
                .RuleFor(x => x.ContentType, f => f.PickRandom<ContentType>())
                .RuleFor(x => x.SubmissionTime, f => f.Date.Future())
                .Generate(10);

            Resources = new Faker<Resource>()
                .RuleFor(x => x.Name, f => f.Lorem.Word())
                .RuleFor(x => x.Url, f => f.Internet.Url())
                .RuleFor(x => x.ResourceType, f => f.PickRandom<ResourceType>())
                .Generate(10);

            Students = new Faker<Student>()
                .RuleFor(x => x.Name, f => f.Person.FirstName)
                .RuleFor(x => x.PhoneNumber, f => f.Person.Phone)
                .RuleFor(x => x.RegisteredOn, f => f.Date.Past())
                .RuleFor(x => x.Birthday, f => f.Date.Past())
                .Generate(10);

            var studentsId = Students.Select(x => x.ID).ToList();
            var courseId = Courses.Select(x => x.ID).ToList();

            for (int i = 0; i < Homeworks.Count; i++)
            {
                Homeworks[i].StudentId = studentsId[i];
                Homeworks[i].CourseId = courseId[i];
            }

            for(int i = 0; i < Resources.Count; i++)
            {
                Resources[i].CourseId = courseId[i];
            }
        }
    }
}
