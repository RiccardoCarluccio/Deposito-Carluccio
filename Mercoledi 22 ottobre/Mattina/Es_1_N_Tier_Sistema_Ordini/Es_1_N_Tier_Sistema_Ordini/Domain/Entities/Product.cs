namespace Es_1_N_Tier_Sistema_Ordini.Domain.Entities;

public class Product
{
    public required string Code { get; set; }
    public required string Name { get; set; }
    public double Price { get; set; }
}