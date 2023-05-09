using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudentDatabase.Data.Enums.ResourceTypeEnum;

namespace StudentDatabase.Data.Models
{
    public class Resource
    {
        public int ResourceId { get; set; }

        public string? Name { get; set; }

        public string? Url { get; set; }

        public ResourceType ResourceType { get; set; }

        public int CourseId { get; set; }

        //many to one
        public Course? Course { get; set; }
    }
}
