using Bogus;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDatabase.Data.Models;
using SalesDatabase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Seeding
{
    public class FakeProductSeeder : ISeeder<Product>
    {
        public void Seed(EntityTypeBuilder<Product> builder)
        {
            var id = 1;

            var faker = new Faker<Product>()
                .RuleFor(e => e.ProductId, f => id++)
                .RuleFor(e => e.Name, f => f.Commerce.ProductName())
                .RuleFor(e => e.Quantity, f => f.Random.Number(1, 10))
                .RuleFor(e => e.Price, f => f.Random.Number(100, 5000));

            var products = faker.Generate(10);
            builder.HasData(products);
        }
    }
}
