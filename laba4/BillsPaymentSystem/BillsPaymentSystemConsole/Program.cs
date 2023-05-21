using BillsPaymentSystem.Data;
using BillsPaymentSystemConsole;
using BillsPaymentSysytem.Data.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var connection = "Server =LENOVOT470\\SQLEXPRESS; Database = Bills_Payments_System_Catalog; Trusted_Connection=True; TrustServerCertificate=True;";

var options = new DbContextOptionsBuilder<BillsPaymentSystemContext>()
                 .UseSqlServer(new SqlConnection(connection))
                 .Options;

var context = new BillsPaymentSystemContext(options);

var repo = new UserRepository(context);

Console.WriteLine("Welcome to the Bills payment system!");
Console.Write("Find info about user with id: ");

//example: F07A157F-2DE2-40F5-84DA-2DDF50A2ED35
var ID = Guid.Parse(Console.ReadLine());
Console.WriteLine();

var userResult = await repo.GetUserById(ID);

if (userResult is not null)
{
    Console.WriteLine($"The user's ID: {userResult.ID}");
    Console.WriteLine($"The user's title: {userResult.FirstName} {userResult.LastName}");
    Console.WriteLine($"The user's email: {userResult.Email}");
    Console.WriteLine();

    var paymentMethodResult = await repo.GetPaymentMethodsByUserId(userResult.ID);

    if(paymentMethodResult is not null )
    {
        List<BankAccount> bankAccountsResult = new List<BankAccount>();
        List<CreditCard> creditCardsResult = new List<CreditCard>();

        foreach(var item in paymentMethodResult)
        {
            var bank = await repo.GetBankAccountByPaymentMethod(item);
            var creditCard = await repo.GetCreditCardByPaymentMethod(item);

            if (bank is not null) { bankAccountsResult.Add(bank); }

            if (creditCard is not null) { creditCardsResult.Add(creditCard); }
        }

        if(bankAccountsResult is not null)
        {
            foreach(var bankAccount in bankAccountsResult)
            {
                Console.WriteLine();
                Console.WriteLine("Bank account: ");
                Console.WriteLine(bankAccount.ID);
                Console.WriteLine(bankAccount.BankName);
                Console.WriteLine(bankAccount.Balance);
                Console.WriteLine(bankAccount.SwiftCode);
            }
        }

        if(creditCardsResult is not null)
        {
            foreach(var creditCard in creditCardsResult)
            {
                Console.WriteLine();
                Console.WriteLine("Credit card: ");
                Console.WriteLine(creditCard.ID);
                Console.WriteLine(creditCard.Limit);
                Console.WriteLine(creditCard.MoneyOwed);
                Console.WriteLine(creditCard.ExpirationDate);
            }
        }
    }
    else
    {
        Console.WriteLine("Payment method was not found!");
    }
}
else
{
    Console.WriteLine("User was not found!");
}

Console.WriteLine("Press enter to exit");
Console.ReadLine();