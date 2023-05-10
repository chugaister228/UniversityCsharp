using BillsPaymentSystem.Data.Interfaces;
using BillsPaymentSysytem.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsPaymentSystem.Data.Seeding
{
    public class UserSeeder : ISeeder<User>
    {
        private static readonly List<User> users = new()
        {
            new User
            {
                UserId = 1,
                Email = "ivan@gmail.com",
                FirstName = "Ivan",
                LastName = "Ivanovych",
                Password = "1jjjdwew343"
            },

            new User
            {
                UserId = 2,
                Email = "stepan@gmail.com",
                FirstName = "Stepan",
                LastName = "Stepanovych",
                Password = "dd887ffhhsk8"
            }
        };

        public void Seed(EntityTypeBuilder<User> builder)
        {
            builder.HasData(users);
        }
    }
}
