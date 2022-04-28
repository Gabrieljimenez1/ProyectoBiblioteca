using ProyectoBiblioteca.Datos.LlamadoServicio;
using Microsoft.EntityFrameworkCore;
using ProyectoBiblioteca.Datos.Modelo;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<RepositorioBiblioteca>(opt =>
{
	opt.UseSqlServer(builder.Configuration.GetConnectionString("NombreConexion"));
});

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
