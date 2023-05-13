using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.DAL.Entities
{
    public class Student : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public DateTime RegisteredOn { get; set; }
        public DateTime Birthday { get; set; }
        public ICollection<StudentCourse> StudentCources { get; set; } = null!;
        public ICollection<Homework> Homeworks { get; set; } = null!;
    }
}
