using Es_1_N_Tier_Sistema_Ordini.Domain.Entities;
using Es_1_N_Tier_Sistema_Ordini.Domain.Interfaces;

namespace Es_1_N_Tier_Sistema_Ordini.Application.Services;

public class ProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Product? GetProductByCode(string code)
    {
        return _productRepository.GetByCode(code);
    }

    public void AddProduct(string code, string name, double price)
    {
        var product = new Product
        {
            Code = code,
            Name = name,
            Price = price
        };

        _productRepository.Add(product);
    }

    public IEnumerable<Product> ListProducts()
    {
        return _productRepository.List();
    }
}
