using BillsPaymentSysytem.Data.Models.Entities;
using BillsPaymentSysytem.Data.Models;
using Bogus;
using BillsPaymentSysytem.Data.Models.Enums;

namespace BillsPaymentSystem.Data
{
    public static class Seeding
    {
        public static List<User> Users { get; set; } = new();
        public static List<CreditCard> CreditCards { get; set; } = new();
        public static List<BankAccount> BankAccounts { get; set; } = new();
        public static List<PaymentMethod> PaymentMethods { get; set; } = new();
        public static void SeedingInit()
        {
            Users = new Faker<User>()
                .RuleFor(x => x.FirstName, f => f.Person.FirstName)
                .RuleFor(x => x.LastName, f => f.Person.LastName)
                .RuleFor(x => x.Email, (f, o) => f.Internet.Email(o.FirstName, o.LastName))
                .RuleFor(x => x.Password, f => f.Internet.Password())
                .Generate(25);

            CreditCards = new Faker<CreditCard>()
                .RuleFor(x => x.ExpirationDate, f => f.Date.Future())
                .RuleFor(x => x.Limit, f => f.Finance.Amount())
                .RuleFor(x => x.MoneyOwed, f => f.Finance.Amount())
                .Generate(75);

            BankAccounts = new Faker<BankAccount>()
                .RuleFor(x => x.Balance, f => f.Finance.Amount())
                .RuleFor(x => x.BankName, f => f.Company.CompanyName())
                .RuleFor(x => x.SwiftCode, f => f.Finance.CreditCardCvv())
                .Generate(75);

            var banksResult = BankAccounts.Select(x => x.ID).ToList();
            var creditsResult = CreditCards.Select(x => x.ID).ToList();

            PaymentMethods = new Faker<PaymentMethod>()
                .RuleFor(x => x.Type, f => f.PickRandom<PaymentMethodType>())
                .RuleFor(x => x.UserId, f => f.PickRandom(Users).ID)
                .Generate(75);

            for (int i = 0; i < PaymentMethods.Count; i++)
            {
                PaymentMethods[i].BankAccountId = banksResult[i];

                PaymentMethods[i].CreditCardId = creditsResult[i];
            }
        }
    }
}
