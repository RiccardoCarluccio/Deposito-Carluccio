namespace Es_3_Delegate_Factory_DInjection.DependencyInjection;

public interface ILogger
{
    void Log(string message);
}

public class Logger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[LOG]: {message}");
    }
}
