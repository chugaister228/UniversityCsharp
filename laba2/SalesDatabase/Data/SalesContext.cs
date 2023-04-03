using Microsoft.EntityFrameworkCore;
using SalesDatabase.Data.Models;

namespace HospitalDatabase.Data
{
    public class SalesContext : DbContext
    {
        public SalesContext(DbContextOptions<SalesContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();

        public DbSet<Customer> Customers => Set<Customer>();

        public DbSet<Store> Stores => Set<Store>();

        public DbSet<Sale> Sales => Set<Sale>();
    }
}
