namespace Es_1_N_Tier_Sistema_Ordini.Domain.Entities;

public class Customer
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public required string Name { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
}
