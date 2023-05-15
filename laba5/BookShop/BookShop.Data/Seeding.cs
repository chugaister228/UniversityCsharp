using BookShop.DAL.Entities;
using Bogus;
using BookShop.DAL.Enums;

namespace BookShop.Data
{
    public static class Seeding
    {
        public static List<Author> Authors { get; set; } = new();
        public static List<Book> Books { get; set; } = new();
        public static List<BookCategory> BookCategories { get; set; } = new();
        public static List<Category> Categories { get; set; } = new();

        public static void SeedingInit()
        {
            Authors = new Faker<Author>()
                .RuleFor(x => x.FirstName, f => f.Person.FirstName)
                .RuleFor(x => x.LastName, f => f.Person.LastName)
                .Generate(10);

            Books = new Faker<Book>()
                .RuleFor(x => x.Title, f => f.Lorem.Word())
                .RuleFor(x => x.Description, f => f.Lorem.Text())
                .RuleFor(x => x.ReleaseDate, f => f.Date.Past())
                .RuleFor(x => x.Copies, f => f.Random.Int())
                .RuleFor(x => x.Price, f => f.Random.Decimal())
                .RuleFor(x => x.EditionType, f => f.PickRandom<EditionType>())
                .RuleFor(x => x.AgeRestriction, f => f.PickRandom<AgeRestriction>())
                .Generate(10);

            Categories = new Faker<Category>()
                .RuleFor(x => x.Name, f => f.Commerce.ProductName())
                .Generate(10);

            BookCategories = new Faker<BookCategory>()
                .Generate(10);

            var authorIds = Authors.Select(x => x.ID).ToList();
            var bookIds = Books.Select(x => x.ID).ToList();
            var categoryIds = Categories.Select(x => x.ID).ToList();

            for (int i = 0; i < Books.Count; i++)
            {
                Books[i].AuthorId = authorIds[i];
            }

            for (int i = 0; i < BookCategories.Count; i++)
            {
                BookCategories[i].BookId = bookIds[i];
                BookCategories[i].CategoryId = categoryIds[i];
            }
        }
    }
}
