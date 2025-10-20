public interface IGreeter
{
    void Greet(string message);
}

public class ConsoleGreeter : IGreeter
{
    public void Greet(string message)
    {
        Console.WriteLine($"Benvenuto, {message}");
    }
}

public class GreetingService
{
    private readonly IGreeter _greeter;

    public GreetingService(IGreeter greeter)
    {
        _greeter = greeter;
    }

    public void GreetUser(string user)
    {
        _greeter.Greet($"{user}");
    }
}

class Program
{
    static void Main()
    {
        IGreeter greeter = new ConsoleGreeter();
        GreetingService greetingService = new GreetingService(greeter);
        greetingService.GreetUser("Mario");
    }
}