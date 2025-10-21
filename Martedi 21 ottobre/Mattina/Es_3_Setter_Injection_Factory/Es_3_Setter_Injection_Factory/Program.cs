using Es_3_Setter_Injection_Factory;
using Es_3_Setter_Injection_Factory.DependencyInjections;
using Es_3_Setter_Injection_Factory.Factory;


Console.WriteLine("Scegli il libro da comprare:\n" +
    "Fisico, Digitale, Esci");

string input = Console.ReadLine()!.Trim().ToLower();

var libro = ProductFactory.OrderBook(input);

IInventoryService inventoryService = new InventoryService();
IPaymentProcessor paymentProcessor = new PaymentProcessor();

var orderService = new OrderService(inventoryService, paymentProcessor);
orderService.GetStock(input);
orderService.Pay();