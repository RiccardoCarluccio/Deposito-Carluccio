namespace Es_1_N_Tier_Sistema_Ordini.Domain.Interfaces;

public interface IClock
{
    DateTimeOffset Now { get; set; }
}
