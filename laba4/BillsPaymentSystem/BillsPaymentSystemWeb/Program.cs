using BillsPaymentSystem.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

//Connection to database
builder.Services.AddDbContext<BillsPaymentSystemContext>(configurations =>
{
    configurations.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), 
        options => options.MigrationsAssembly("BillsPaymentSystem.Migrations"));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
