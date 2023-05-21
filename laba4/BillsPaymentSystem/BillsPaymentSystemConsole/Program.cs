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
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Bank accounts: {bankAccountsResult.Count}");

            foreach (var bankAccount in bankAccountsResult)
            {
                Console.WriteLine();
                Console.Write("Bank account: ");
                Console.WriteLine(bankAccount.ID);
                Console.WriteLine($"Bank name: {bankAccount.BankName}");
                Console.WriteLine($"Balance: {bankAccount.Balance}");
                Console.WriteLine($"Swift: {bankAccount.SwiftCode}");
            }
        }

        if(creditCardsResult is not null)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Credit cards: {creditCardsResult.Count}");

            decimal limitLeft = 0;

            foreach (var creditCard in creditCardsResult)
            {
                limitLeft = creditCard.Limit - creditCard.MoneyOwed;

                Console.WriteLine();
                Console.Write("Credit card: ");
                Console.WriteLine(creditCard.ID);
                Console.WriteLine($"Limit: {creditCard.Limit}");
                Console.WriteLine($"Money owed: {creditCard.MoneyOwed}");
                Console.WriteLine($"Expiration date: {creditCard.ExpirationDate}");
                Console.WriteLine($"Limit left: {limitLeft}");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Do you want to make withdraw for credit card? (1)");
        Console.WriteLine("Do you want to make deposit for bank account? (2)");
        Console.WriteLine("Do you want to pay bills? (3)");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.Write("Cerdit card ID: ");
                var creditCardID = Guid.Parse(Console.ReadLine());

                await repo.WithdrawCreditCardById(creditCardID);
                Console.WriteLine("Done!");
                break;

            case "2":
                Console.Write("Bank account ID: ");
                var bankAccountID = Guid.Parse(Console.ReadLine());
                Console.Write("Amount: ");
                var amount = Decimal.Parse(Console.ReadLine());

                await repo.DepositBankAccountById(bankAccountID, amount);
                Console.WriteLine("Done!");
                break;

            case "3":
                Console.Write("Amount: ");
                var amount1 = Decimal.Parse(Console.ReadLine());

                await repo.PayBills(bankAccountsResult, creditCardsResult, amount1);
                Console.WriteLine("Done!");
                break;
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

Console.WriteLine();
Console.WriteLine("Press enter to exit");
Console.ReadLine();