using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase.Data.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Price { get; set; }

        //one to many
        public ICollection<Homework>? Homeworks { get; set; }

        //one to many
        public ICollection<Resource>? Resources { get; set; }

        //one to many
        public ICollection<StudentCourse>? StudentCources { get; set; } 
    }
}
