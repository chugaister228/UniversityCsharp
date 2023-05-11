using HospitalDatabase.Console;
using HospitalDatabase.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var connection = "Server =LENOVOT470\\SQLEXPRESS; Database = Hospital_Database; Trusted_Connection=True; TrustServerCertificate=True;";

var options = new DbContextOptionsBuilder<HospitalContext>()
                 .UseSqlServer(new SqlConnection(connection))
                 .Options;

var context = new HospitalContext(options);

var repo = new DoctorRepository(context);

Console.WriteLine("Welcome to the Hospital database!");
Console.WriteLine();

//example: J7aabFqxu6
Console.Write("Login: ");
string login  = Console.ReadLine();
Console.WriteLine();

//example: Giuseppe.Emmerich@hotmail.com
Console.Write("Email: ");
string email = Console.ReadLine();
Console.WriteLine();

var doctorResult = await repo.GetDoctorByLoginAndEmail(login, email);

Console.WriteLine($"Name: {doctorResult.Name}");
Console.WriteLine($"Speciality: {doctorResult.Speciality}");
Console.WriteLine();

Console.WriteLine("Press enter to exit");
Console.ReadLine();
