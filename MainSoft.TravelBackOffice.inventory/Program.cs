using Leal.Core.CargaPuntos.Application.WepApi;
using MainSoft.TravelBackOffice.Infraestructure.Core;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var strinconecixon = builder.Configuration.GetConnectionString("TravelInventoryDB");
// Add services to the container.

builder.Services.AddDbContext<TravelInventoryContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("TravelInventoryDB")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
StartUp.RegisterDI<TravelInventoryContext>(builder.Services, builder.Configuration);
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
