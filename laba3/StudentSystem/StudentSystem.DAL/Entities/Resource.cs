using StudentSystem.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.DAL.Entities
{
    public class Resource : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Url { get; set; } = null!;
        public ResourceType ResourceType { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; } = null!;
    }
}
