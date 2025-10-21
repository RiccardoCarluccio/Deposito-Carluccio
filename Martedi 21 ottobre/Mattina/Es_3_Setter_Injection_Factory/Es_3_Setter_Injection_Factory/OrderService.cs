using Es_3_Setter_Injection_Factory.DependencyInjections;
using Es_3_Setter_Injection_Factory.SetterInjections;

namespace Es_3_Setter_Injection_Factory;

public class OrderService
{
    private readonly IInventoryService _inventoryService;
    private readonly IPaymentProcessor _paymentProcessor;

    public INotificationSender? _notificationSender;
    public IPricingStrategy? _pricingStrategy;

    public OrderService(
        IInventoryService inventoryService,
        IPaymentProcessor paymentProcessor)
    {
        _inventoryService = inventoryService;
        _paymentProcessor = paymentProcessor;
    }

    public void GetStock(string type)
    {
        _inventoryService.GetAvailability(type);
    }

    public void Pay()
    {
        _paymentProcessor.ExecutePayment();
    }

    public void Notify(string message)
    {
        if ( _notificationSender == null )
        {
            Console.WriteLine("Notifiche disabilitate");
            return;
        }
        _notificationSender.SendNotification(message);
        Console.WriteLine("Notifica inviata");
    }

    public void Pricing(double price)
    {
        if (_pricingStrategy == null)
        {
            Console.WriteLine("Prezzo non trovato");
            return;
        }
        _pricingStrategy.Price(price);
        Console.WriteLine("Prezzo ufficiale");
    }
}
