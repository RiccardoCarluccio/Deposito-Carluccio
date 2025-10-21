namespace Es_3_Setter_Injection_Factory.DependencyInjections;

public interface IInventoryService
{
    bool GetAvailability(string type);
}

public interface IPaymentProcessor
{
    void ExecutePayment();
}

public class InventoryService : IInventoryService
{
    public bool GetAvailability(string type)
    {
        switch (type)
        {
            case "fisico":
                Console.WriteLine($"{type} non è al momento disponibile");
                return false;

            case "digitale":
                Console.WriteLine($"{type} è disponibile");
                return true;

            default:
                Console.WriteLine("Tipo di libro non valido");
                return false;
        }
    }
}

public class PaymentProcessor : IPaymentProcessor
{
    public void ExecutePayment()
    {
        Console.WriteLine("Reindirizzamento a PayPal in corso...");
        Console.WriteLine("Pagamento eseguito con successo");
    }
}