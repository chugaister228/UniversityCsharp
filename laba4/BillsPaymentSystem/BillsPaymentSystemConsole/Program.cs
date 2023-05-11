using BillsPaymentSystem.Data;
using BillsPaymentSystemConsole;
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

Console.WriteLine($"The user's ID: {userResult.ID}");
Console.WriteLine($"The user's title: {userResult.FirstName} {userResult.LastName}");
Console.WriteLine($"The user's email: {userResult.Email}");
Console.WriteLine();

var bankAccountResult = await repo.GetBankAccountByUserId(ID);

Console.WriteLine($"The bank`s account ID: {bankAccountResult.ID}");
Console.WriteLine($"The bank`s account Name: {bankAccountResult.BankName}");
Console.WriteLine($"The bank`s account balance: {bankAccountResult.Balance}");
Console.WriteLine($"The bank`s account SwiftCode: {bankAccountResult.SwiftCode}");
Console.WriteLine();

var creditCardResult = await repo.GetCreditCardByUserId(ID);

Console.WriteLine($"The credit card`s ID: {creditCardResult.ID}");
Console.WriteLine($"The credit card`s account Limit: {creditCardResult.Limit}");
Console.WriteLine($"The credit card`s account MoneyOwed: {creditCardResult.MoneyOwed}");
Console.WriteLine($"The credit card`s account ExpirationDate: {creditCardResult.ExpirationDate}");
Console.WriteLine();

Console.WriteLine("Press enter to exit");
Console.ReadLine();