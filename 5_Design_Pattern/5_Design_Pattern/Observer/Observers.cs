namespace _5_Design_Pattern.Observer;

public class Observers
{
    public class DisplayConsole : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"[Display console]: {message}");
        }
    }

    public class DisplayMobile : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"[Display mobile]: {message}");
        }
    }
}
