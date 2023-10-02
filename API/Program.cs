using API.Extensiones;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddApplicationServices(builder.Configuration);

//ESTO LO HEMOS HECHO PARA PODER METER LA CONFIGURACION DE MI DATACONTEXT QUE VA A SER UNA CONEXION A SQLLITE
// POR LO QUE HAY QUE INSTALAR EL SQLLITE SIN SER CORE

builder.Services.AddIdentityServices(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().
        WithOrigins("https://localhost:4200"));



app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
