namespace Es_3_Setter_Injection_Factory.SetterInjections;

public interface INotificationSender
{
    void SendNotification(string message);
}

public interface IPricingStrategy
{
    void Price(double price);
}

public class NotificationSender : INotificationSender
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"NotificationSender: {message}");
    }
}

public class PricingStrategy : IPricingStrategy
{
    public void Price(double price)
    {
        Console.WriteLine($"Il prezzo è {price}");
    }
}
