using Microsoft.AspNetCore.Mvc;
using Proyecto.Queries.Producto;
using Proyecto.Queries.ProductoxTienda;
using Proyecto.Queries.Tienda;
using Proyecto.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

builder.Services.AddTransient<IProductoQueries, ProductoQueries>();
builder.Services.AddTransient<IProductoRepository, ProductoRepository>();
builder.Services.AddTransient<ITiendaQueries, TiendaQueries>();
builder.Services.AddTransient<ITiendaRepository, TiendaRepository>();
builder.Services.AddTransient<IProductoxTiendaQueries, ProductoxTiendaQueries>();
builder.Services.AddTransient<IProductoxTiendaRepository, ProductoxTiendaRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
