using Es_3_Setter_Injection_Factory.DependencyInjections;
using Es_3_Setter_Injection_Factory.SetterInjections;

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
}