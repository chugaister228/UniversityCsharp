using BookShop.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BookShop.Data
{
    public class BookShopContext : DbContext
    {
        public BookShopContext(DbContextOptions<BookShopContext> options) : base(options) { }

        public DbSet<Author> Authors => Set<Author>();
        public DbSet<Book> Books => Set<Book>();
        public DbSet<BookCategory> BookCategories => Set<BookCategory>();
        public DbSet<Category> Categories => Set<Category>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            Seeding.SeedingInit();

            modelBuilder.Entity<Author>().HasData(Seeding.Authors);
            modelBuilder.Entity<Book>().HasData(Seeding.Books);
            modelBuilder.Entity<BookCategory>().HasData(Seeding.BookCategories);
            modelBuilder.Entity<Category>().HasData(Seeding.Categories);
        }
    }
}
