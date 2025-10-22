using Es_1_N_Tier_Sistema_Ordini.Domain.Entities;

namespace Es_1_N_Tier_Sistema_Ordini.Domain.Interfaces;

public interface IOrderRepository
{
    Order? GetById(Guid id);
    void Add(Order order);
    void Update(Order order);
    IEnumerable<Order> List();
}
