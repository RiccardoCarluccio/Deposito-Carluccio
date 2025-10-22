namespace Es_1_N_Tier_Sistema_Ordini.Domain.Entities;

public class OrderItem
{
    public required Product Product { get; set; }
    public int Quantity { get; set; }
}
