using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase.Data.Models
{
    public class StudentCourse
    {
        public int StudentId { get; set; }

        //many to one
        public Student? Student { get; set; }

        public int CourseId { get; set; }

        //many to one
        public Course? Course { get; set; }
    }
}
