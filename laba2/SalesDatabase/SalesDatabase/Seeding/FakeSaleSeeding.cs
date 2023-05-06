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
    public class FakeSaleSeeding : ISeeder<Sale>
    {
        public void Seed(EntityTypeBuilder<Sale> builder)
        {
            var id = 1;

            var faker = new Faker<Sale>()
                .RuleFor(e => e.SaleId, f => id++)
                .RuleFor(e => e.Date, f => f.Date.Past())
                .RuleFor(e => e.CustomerId, f => f.Random.Number(1, 10))
                .RuleFor(e => e.ProductId, f => f.Random.Number(1, 10))
                .RuleFor(e => e.StoreId, f => f.Random.Number(1, 10));

            var sales = faker.Generate(10);
            builder.HasData(sales);
        }
    }
}
