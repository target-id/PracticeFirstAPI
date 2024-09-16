using Microsoft.EntityFrameworkCore;
using Practica.Persistencia.Extensiones;
using Practica.Persistencia.Repositorio;
using Practica.Aplicacion.Extensiones;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddPersistenceService(builder.Configuration);//se pasa la cadena de conexion hecha en la persistencia
builder.Services.AddAplicationServices();
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
