using Es_1_N_Tier_Sistema_Ordini.Domain.Entities;
using Es_1_N_Tier_Sistema_Ordini.Domain.Interfaces;

namespace Es_1_N_Tier_Sistema_Ordini.Infrastructure.Repositories;

public class InMemoryProductRepository : IProductRepository
{
    private readonly Dictionary<string, Product> _products = [];

    public void Add(Product product)
    {
        _products.Add(product.Code, product);
    }

    public Product? GetByCode(string code)
    {
        _products.TryGetValue(code, out var product);
        return product;
    }

    public IEnumerable<Product> List()
    {
        return _products.Values;
    }
}
