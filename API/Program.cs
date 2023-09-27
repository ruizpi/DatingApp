using API.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//ESTO LO HEMOS HECHO PARA PODER METER LA CONFIGURACION DE MI DATACONTEXT QUE VA A SER UNA CONEXION A SQLLITE
// POR LO QUE HAY QUE INSTALAR EL SQLLITE SIN SER CORE
builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200"));


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
