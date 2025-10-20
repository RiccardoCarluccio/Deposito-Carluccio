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

public interface ILogger
{
    void Log(string logMessage);
}

public class Logger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[LOG]: {message}");
    }
}

public class GreetingService
{
    private readonly IGreeter _greeter;
    private readonly ILogger? _logger;

    public GreetingService(IGreeter greeter)    //viene dichiarata una dipendenza da 'IGreeter' tramite costruttore
    {                                           //non crea 'ConsoleGreeter' direttamente dentro di sè. Si aspetta che gli venga fornito
        _greeter = greeter;                     //la dipendenza non è creata internamente, ma iniettata dall'esterno
    }

    public GreetingService(
        IGreeter greeter,
        ILogger logger)
    {
        _greeter = greeter;
        _logger = logger;
    }

    public void GreetUser(string user)
    {
        _greeter.Greet($"{user}");
    }

    public void GreetAndLog(string user, string message)
    {
        _greeter.Greet($"{user}");
        _logger?.Log($"{user}\n" +
            $"{message}");
    }
}

class Program
{
    static void Main()
    {
        IGreeter greeter = new ConsoleGreeter();
        GreetingService greetingService = new GreetingService(greeter);
        greetingService.GreetUser("Mario");

        Console.WriteLine("");

        ILogger logger = new Logger();
        var greetingService_Log = new GreetingService(greeter, logger);
        greetingService_Log.GreetAndLog("Alice", "From Console");
    }
}