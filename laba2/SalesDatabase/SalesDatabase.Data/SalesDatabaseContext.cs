using Microsoft.EntityFrameworkCore;
using SalesDatabase.DAL.Entities;
using System.Reflection;

namespace SalesDatabase.Data
{
    public class SalesDatabaseContext : DbContext
    {
        public SalesDatabaseContext(DbContextOptions<SalesDatabaseContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            Seeding.SeedingInit();

            modelBuilder.Entity<Customer>().HasData(Seeding.Customers);

            modelBuilder.Entity<Product>().HasData(Seeding.Products);

            modelBuilder.Entity<Sale>().HasData(Seeding.Sales);

            modelBuilder.Entity<Store>().HasData(Seeding.Stores);
        }
    }
}
