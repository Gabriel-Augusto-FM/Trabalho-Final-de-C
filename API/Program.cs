using GerenciamentoVolei._01_Services;
using GerenciamentoVolei._01_Services.Interfaces;
using GerenciamentoVolei._02_Repository.Interfaces;
using GerenciamentoVolei._03_Repository;
using GerenciamentoVolei._04_Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IEquipeService, EquipeService>();
builder.Services.AddScoped<IEstatisticasPartidaService, EstatisticasPartidaService>();
builder.Services.AddScoped<IJogadorService, JogadorService>();
builder.Services.AddScoped<IPresencaService, PresencaService>();
builder.Services.AddScoped<ITreinadorService, TreinadorService>();
builder.Services.AddScoped<ITreinamentoService, TreinamentoService>();

builder.Services.AddScoped<IEquipeRepository, EquipeRepository>();
builder.Services.AddScoped<IEstatisticasPartidaRepository, EstatisticasPartidaRepository>();
builder.Services.AddScoped<IJogadorRepository, JogadorRepository>();
builder.Services.AddScoped<IPresencaRepository, PresencaRepository>();
builder.Services.AddScoped<ITreinadorRepository, TreinadorRepository>();
builder.Services.AddScoped<ITreinamentoRepository, TreinamentoRepository>();


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
