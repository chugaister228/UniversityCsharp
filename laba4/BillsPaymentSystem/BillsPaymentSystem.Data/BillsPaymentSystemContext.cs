using BillsPaymentSysytem.Data.Models;
using BillsPaymentSysytem.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BillsPaymentSystem.Data
{
    public class BillsPaymentSystemContext : DbContext
    {
        public BillsPaymentSystemContext(DbContextOptions<BillsPaymentSystemContext> options) : base(options) { }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<User> Users {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            Seeding.SeedingInit();

            modelBuilder.Entity<User>().HasData(Seeding.Users);

            modelBuilder.Entity<CreditCard>().HasData(Seeding.CreditCards);

            modelBuilder.Entity<BankAccount>().HasData(Seeding.BankAccounts);

            modelBuilder.Entity<PaymentMethod>().HasData(Seeding.PaymentMethods);
        }
    }
}
