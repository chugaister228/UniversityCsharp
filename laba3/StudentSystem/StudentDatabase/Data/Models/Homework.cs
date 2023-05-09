using StudentDatabase.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudentDatabase.Data.Enums.ContentTypeEnum;

namespace StudentDatabase.Data.Models
{
    public class Homework
    {
        public int HomeworkId { get; set; }

        public string? Content { get; set; }

        public ContentType ContentType { get; set; }

        public DateTime SubmissionTime { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        //many to one
        public Student? Student { get; set; }

        //many to one
        public Course? Course { get; set; }
    }
}
