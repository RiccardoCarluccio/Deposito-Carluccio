using Es_3_Setter_Injection_Factory;
using Es_3_Setter_Injection_Factory.DependencyInjections;
using Es_3_Setter_Injection_Factory.Factory;
using Es_3_Setter_Injection_Factory.SetterInjections;


Console.WriteLine("Scegli il libro da comprare:\n" +
    "Fisico, Digitale");

string input = Console.ReadLine()!.Trim().ToLower();

var libro = ProductFactory.OrderBook(input);

IInventoryService inventoryService = new InventoryService();
IPaymentProcessor paymentProcessor = new PaymentProcessor();

//Dependency Injections
var orderService = new OrderService(inventoryService, paymentProcessor);
var availability = orderService.GetStock(input);
orderService.Pay(availability);

//Setter Injections
orderService._notificationSender = new NotificationSender();
orderService._pricingStrategy = new PricingStrategy();

if (availability)
    orderService.Notify($"{libro.Title} è stato comprato");
else
    orderService.Notify($"{libro.Title} non è stato comprato");

orderService.Pricing(libro.Price);
