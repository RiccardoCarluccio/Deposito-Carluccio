using Es_1_N_Tier_Sistema_Ordini.Domain.Entities;

namespace Es_1_N_Tier_Sistema_Ordini.Domain.Interfaces;

public interface IProductRepository
{
    Product? GetByCode(string code);
    void Add(Product product);
    IEnumerable<Product> List();
}
