using ECommerce.Application.Services.Implementations;
using ECommerce.Application.Services.Interfaces;
using ECommerce.Domain.Repositories;
using ECommerce.Infrastructure.Data;
using ECommerce.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using ECommerce.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// ------------------------------------------------------
// Add Controllers
// ------------------------------------------------------
builder.Services.AddControllers();

// add infrastructure (DbContext + provider selection)
builder.Services.AddInfrastructure(builder.Configuration);

// ------------------------------------------------------
//  Repository Registrations
// ------------------------------------------------------
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderItemRepository, OrderItemRepository>();


// ------------------------------------------------------
//  Service Registrations (Application Layer)
// ------------------------------------------------------
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderItemService, OrderItemService>();


// ------------------------------------------------------
//  Swagger
// ------------------------------------------------------
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// ------------------------------------------------------
// Middleware Pipeline
// ------------------------------------------------------
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
