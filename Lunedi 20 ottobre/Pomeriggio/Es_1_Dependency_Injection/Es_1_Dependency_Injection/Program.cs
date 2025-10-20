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

    public GreetingService(IGreeter greeter)    //viene dichiarata una dipendenza da 'IGreeter' tramite costruttore
    {                                           //non crea 'ConsoleGreeter' direttamente dentro di sè. Si aspetta che gli venga fornito
        _greeter = greeter;                     //la dipendenza non è creata internamente, ma iniettata dall'esterno
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