namespace Es_1_N_Tier_Sistema_Ordini.Domain.Interfaces;

public interface INotificationService
{
    void Send(string subject, string body, string to);
}
