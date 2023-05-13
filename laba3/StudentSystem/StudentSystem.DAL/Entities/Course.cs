using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.DAL.Entities
{
    public class Course : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public ICollection<Homework>? Homeworks { get; set; }
        public ICollection<Resource>? Resources { get; set; }
        public ICollection<StudentCourse>? StudentCources { get; set; }

    }
}
