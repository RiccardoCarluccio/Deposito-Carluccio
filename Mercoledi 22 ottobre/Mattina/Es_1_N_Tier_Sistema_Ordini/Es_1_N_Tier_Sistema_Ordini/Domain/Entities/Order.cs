namespace Es_1_N_Tier_Sistema_Ordini.Domain.Entities;

public class Order
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public required Customer Customer { get; set; }
    public required List<OrderItem> Items { get; set; }
    public OrderStatus Status { get; private set; } = OrderStatus.New;

    public void AddOrderItem(OrderItem item, int quantity)
    {
        Items.Add(item);
    }
}
