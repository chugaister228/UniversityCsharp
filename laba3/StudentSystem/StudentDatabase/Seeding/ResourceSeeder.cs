using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentDatabase.Data.Models;
using StudentDatabase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudentDatabase.Data.Enums.ResourceTypeEnum;

namespace StudentDatabase.Seeding
{
    public class ResourceSeeder : ISeeder<Resource>
    {
        private static readonly List<Resource> resources = new()
        {
            new Resource
            {
                ResourceId = 1,
                Name = "Integral video",
                Url = "www.video.com",
                ResourceType = ResourceType.Video,
                CourseId = 1
            },

            new Resource
            {
                ResourceId = 2,
                Name = "С# video",
                Url = "www.video.com",
                ResourceType = ResourceType.Video,
                CourseId = 2
            }
        };

        public void Seed(EntityTypeBuilder<Resource> builder)
        {
            builder.HasData(resources);
        }
    }
}
