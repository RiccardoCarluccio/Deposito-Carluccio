namespace Es_1_Method_Injection_AlertService.Method_Injection;

public interface INotifier
{
    void Notify(string message);
}

public class SmsNotifier : INotifier
{
    public void Notify(string message)
    {
        Console.WriteLine($"{message}\n" +
            $"Message sent via SMS");
    }
}