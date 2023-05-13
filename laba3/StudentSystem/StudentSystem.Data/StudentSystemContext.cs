using Microsoft.EntityFrameworkCore;
using StudentSystem.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext(DbContextOptions<StudentSystemContext> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            Seeding.SeedingInit();

            modelBuilder.Entity<Course>().HasData(Seeding.Courses);
            modelBuilder.Entity<Homework>().HasData(Seeding.Homeworks);
            modelBuilder.Entity<Resource>().HasData(Seeding.Resources);
            modelBuilder.Entity<Student>().HasData(Seeding.Students);
        }
    }
}
