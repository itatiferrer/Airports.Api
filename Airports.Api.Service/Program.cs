using Microsoft.EntityFrameworkCore;
using Airports.Api.Service.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregar los servicios al contenedor.
builder.Services.AddDbContext<Issco2026AirportsDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("AirportsDb")));

builder.Services.AddControllers();

// Configuración de Swagger para documentar y probar la API.
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar el pipeline de solicitudes HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Redireccionar las solicitudes HTTP a HTTPS.
app.UseHttpsRedirection();

// Habilitar la autorización.
app.UseAuthorization();

// Mapear los controladores de la API.
app.MapControllers();

app.Run();
