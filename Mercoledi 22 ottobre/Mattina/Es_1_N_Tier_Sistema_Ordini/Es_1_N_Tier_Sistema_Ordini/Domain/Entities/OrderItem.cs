namespace Es_1_N_Tier_Sistema_Ordini.Domain.Entities;

public class OrderItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public OrderItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
}
