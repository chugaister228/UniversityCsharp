using SalesDatabase.DAL.Entities;
using Bogus;

namespace SalesDatabase.Data
{
    public static class Seeding
    {
        public static List<Customer> Customers { get; set; } = new();
        public static List<Product> Products { get; set; } = new();
        public static List<Sale> Sales { get; set; } = new();
        public static List<Store> Stores { get; set; } = new();
        public static void SeedingInit()
        {
            Customers = new Faker<Customer>()
                .RuleFor(x => x.Name, f => f.Person.FirstName)
                .RuleFor(x => x.Email, f => f.Person.Email)
                .RuleFor(x => x.CreditCardNumber, f => f.Finance.CreditCardNumber())
                .Generate(10);

            Products = new Faker<Product>()
                .RuleFor(x => x.Name, f => f.Commerce.ProductName())
                .RuleFor(x => x.Quantity, f => f.PickRandom(1, 2, 3, 4, 5))
                .RuleFor(x => x.Price, f => f.PickRandom(1000, 2000, 3000))
                .RuleFor(x => x.Description, f=> f.Commerce.ProductDescription())
                .Generate(10);

            Stores = new Faker<Store>()
                .RuleFor(x => x.Name, f => f.Company.CompanyName())
                .Generate(10);

            var customersResult = Customers.Select(x => x.ID).ToList();
            var productsResult = Products.Select(x => x.ID).ToList();
            var storesResult = Stores.Select(x => x.ID).ToList();

            Sales = new Faker<Sale>()
                .RuleFor(x => x.Date, f => f.Date.Future())
                .Generate(10);

            for (int i = 0; i < Sales.Count; i++)
            {
                Sales[i].CustomerId = customersResult[i];
                Sales[i].ProductId = productsResult[i];
                Sales[i].StoreId = storesResult[i];
            }
        }
    }
}
