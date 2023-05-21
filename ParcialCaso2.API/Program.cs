using Microsoft.EntityFrameworkCore;
using ParcialCaso2.API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var _config = builder.Configuration;
var _cnx = _config.GetConnectionString("DevConnection");
builder.Services.AddDbContext<Parcial202320100651Context>(options => options.UseSqlServer(_cnx));

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

app.UseAuthorization();

app.MapControllers();

app.Run();
