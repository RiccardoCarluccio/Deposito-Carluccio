public interface IPaymentGateway
{
    void Pay(double cost);
}

public class PaypalGateway : IPaymentGateway
{
    public void Pay(double cost)
    {
        Console.WriteLine($"Payment of {cost} done with PayPal");
    }
}

public class StripeGateway : IPaymentGateway
{
    public void Pay(double cost)
    {
        Console.WriteLine($"Payment of {cost} done with Stripe");
    }
}

public class PaymentProcess
{
    private readonly IPaymentGateway _gateway;

    public PaymentProcess(IPaymentGateway gateway)
    {
        _gateway = gateway;
    }

    public void Pay(double cost)
    {
        _gateway.Pay(cost);
    }
}

class Program
{
    static void Main()
    {
        IPaymentGateway? gateway = null;

        Console.WriteLine("Choose your preferred payment method:\n" +
            "1. PayPal\n" +
            "2. Stripe");
        int input = int.Parse(Console.ReadLine()!);

        switch (input)
        {
            case 1:
                gateway = new PaypalGateway();
                break;

            case 2:
                gateway = new StripeGateway();
                break;

            default:
                Console.WriteLine("Invalid input");
                break;
        }
        
        var paymentProcess = new PaymentProcess(gateway);
        paymentProcess.Pay(25);
    }
}