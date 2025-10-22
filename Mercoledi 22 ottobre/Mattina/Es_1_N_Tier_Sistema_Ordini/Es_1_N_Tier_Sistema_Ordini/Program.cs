using Es_1_N_Tier_Sistema_Ordini.Application.Services;
using Es_1_N_Tier_Sistema_Ordini.Domain.Interfaces;
using Es_1_N_Tier_Sistema_Ordini.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddSingleton<IProductRepository, InMemoryProductRepository>();
services.AddSingleton<IOrderRepository, InMemoryOrderRepository>();

services.AddSingleton<ProductService>();
services.AddSingleton<OrderService>();

var serviceProvider = services.BuildServiceProvider();

var productService = serviceProvider.GetRequiredService<ProductService>();
var orderService = serviceProvider.GetRequiredService<OrderService>();

