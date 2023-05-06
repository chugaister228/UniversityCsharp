using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDatabase.Data.Models;
using SalesDatabase.Interfaces;

namespace SalesDatabase.Seeding
{
    public class FakeCustomerSeeder : ISeeder<Customer>
    {
        public void Seed(EntityTypeBuilder<Customer> builder) 
        {
            var id = 1;

            var faker = new Faker<Customer>()
                .RuleFor(e => e.CustomerId, f => id++)
                .RuleFor(e => e.Name, f => f.Name.FirstName())
                .RuleFor(e => e.Email, f => f.Internet.Email())
                .RuleFor(e => e.CreditCardNumber, f => f.Finance.CreditCardNumber());

            var customers = faker.Generate(10);
            builder.HasData(customers); 
        }
    }
}
