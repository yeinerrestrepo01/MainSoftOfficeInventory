using Leal.Core.CargaPuntos.Application.WepApi;
using MainSoft.TravelBackOffice.Infraestructure.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddDbContext<TravelInventoryContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("TravelInventoryDB")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(swagger =>
{
    var contact = new OpenApiContact
    {
        Name = "MeisonSoft TravelOffice API"

    };
    swagger.SwaggerDoc("v1",
    new OpenApiInfo
    {
        Title = "MainSoft.TravelBackOffice.InventoryApi",
        Version = "v1",
        Description = "MainSoft Biblioteca  API  - Documentation Services",
        Contact = contact

    });
});
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
