using StudentSystem.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.DAL.Entities
{
    public class Homework : BaseEntity
    {
        public string Content { get; set; } = null!;
        public ContentType ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public Student Student { get; set; } = null!;
        public Course Course { get; set; } = null!;
    }
}
