using Es_3_Dependency_Injection_Singleton.Singleton;

namespace Es_3_Dependency_Injection_Singleton;

public interface ILogger
{
    void Log(string message);
}

public class LoggerService : ILogger
{
    private readonly AppConfig _config;

    public LoggerService(AppConfig config)
    {
        _config = config;
    }

    public void Log(string message)
    {
        Console.WriteLine($"[LOG]: {message}");
    }
}

public class OrderService
{
    private readonly ILogger _logger;

    public OrderService(ILogger logger)
    {
        _logger = logger;
    }

    public void CreateOrder(string product, string message)
    {
        _logger.Log($"Order for {product} had been {message}");
    }
}