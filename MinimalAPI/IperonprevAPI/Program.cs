using IperonprevAPI.EndPoints;
using IperonprevAPI.Repository;
using IperonprevAPI.Services;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Configuração do banco de dados
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var connectionString2 = builder.Configuration.GetConnectionString("DefaultConnection2");

// Registrando o repositório e o serviço
builder.Services.AddSingleton(new NoticiaRepository(connectionString));
builder.Services.AddSingleton(new SistemaRepository(connectionString2));

builder.Services.AddScoped<NoticiaService>();
builder.Services.AddScoped<SistemaService>();

// Add services to the container.
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.MapNoticia();
app.MapSistema();

app.Run();

