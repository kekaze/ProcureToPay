using Microsoft.EntityFrameworkCore;
using ProcureToPay.Models;

var builder = WebApplication.CreateBuilder(args);

var sqlServerName = Environment.GetEnvironmentVariable("SQL_SERVER_NAME");
var dbSettings = builder.Configuration.GetConnectionString("ProcureToPayDatabase");
var connectionString = string.Format("server={0}; {1}", sqlServerName, dbSettings);

// Add services to the container.
builder.Services.AddDbContext<ProcureToPayContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
