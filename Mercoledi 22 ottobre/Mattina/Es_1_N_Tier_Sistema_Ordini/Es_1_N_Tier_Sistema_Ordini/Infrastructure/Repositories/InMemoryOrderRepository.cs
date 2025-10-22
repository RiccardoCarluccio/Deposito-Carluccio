using Es_1_N_Tier_Sistema_Ordini.Domain.Entities;
using Es_1_N_Tier_Sistema_Ordini.Domain.Interfaces;

namespace Es_1_N_Tier_Sistema_Ordini.Infrastructure.Repositories;

public class InMemoryOrderRepository : IOrderRepository
{
    private readonly Dictionary<Guid, Order> _orders = [];

    public void Add(Order order)
    {
        _orders.Add(order.Id, order);
    }

    public Order? GetById(Guid id)
    {
        _orders.TryGetValue(id, out var order);
        return order;
    }

    public IEnumerable<Order> List()
    {
        return _orders.Values;
    }

    public void Update(Order order)
    {
        _orders[order.Id] = order;
    }
}
