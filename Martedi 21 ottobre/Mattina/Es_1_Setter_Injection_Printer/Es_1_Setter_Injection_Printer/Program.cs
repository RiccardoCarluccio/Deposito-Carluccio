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

public class Printer
{
    public ILogger? logger { get; set; }

    public void Print()
    {
        if (logger == null )
        {
            Console.WriteLine("Logger non impostato");
            return;
        }
        logger.Log("Stampa messaggio");
        Console.WriteLine("Messaggio stampato con successo");
    }
}

class Program
{
    static void Main()
    {
        var printer = new Printer();
        printer.logger = new Logger();
        printer.Print();
    }
}