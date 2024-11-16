using pedidosPizza.Data;
using pedidosPizza.Service.Impl;
using pedidosPizza.Service;
using pedidosPizza.Factory;
using pedidosPizza.Data.Repositories.Interfaces;
using pedidosPizza.Data.Repositories.Implementacion;
using pedidosPizza.PricingStrategies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IIngredienteService, IngredienteService>();

builder.Services.AddScoped<IModelFactory, ModelFactory>();
// Registrar otros servicios (si no lo has hecho ya)
builder.Services.AddScoped<IPedidoService, PedidoService>();
builder.Services.AddScoped<IPizzaService, PizzaService>();
builder.Services.AddSingleton<DataBaseHandler>();
builder.Services.AddScoped<IModelFactory, ModelFactory>();
builder.Services.AddScoped<IIngredienteRepository, IngredienteRepository>();
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<IPizzaRepository, PizzaRepository>();
builder.Services.AddScoped<PricingService>();
builder.Services.AddScoped<IPricingStrategy, NoPromotionStrategy>();
builder.Services.AddScoped<IPricingStrategy, TwoForOnePromotionStrategy>();
  

builder.Services.AddEndpointsApiExplorer();
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
