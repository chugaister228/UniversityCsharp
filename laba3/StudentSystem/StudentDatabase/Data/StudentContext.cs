using Microsoft.EntityFrameworkCore;
using StudentDatabase.Configuration;
using StudentDatabase.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<Course> Courses => Set<Course>();

        public DbSet<Homework> Homeworks => Set<Homework>();

        public DbSet<Resource> Resources => Set<Resource>();

        public DbSet<Student> Students => Set<Student>();

        public DbSet<StudentCourse> StudentCources => Set<StudentCourse>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new HomeworkConfiguration());
            modelBuilder.ApplyConfiguration(new ResourceConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentCourseConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=StudentDatabase;Trusted_Connection=True;TrustServerCertificate=True;", b => b.MigrationsAssembly("StudentWeb"));
            }
        }
    }
}
