using _5_Design_Pattern.Observer;

namespace _5_Design_Pattern.Singleton;

public sealed class CoffeeMachine : ISubject
{
    private static CoffeeMachine _instance;

    private static object _lock = new object();

    private readonly Dictionary<string, int> availability = new()
    {
        { "Tea", 1 },
        { "Coffee", 1 }
    };

    private readonly List<IObserver> _observers = new();

    private CoffeeMachine() { }

    public static CoffeeMachine Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new CoffeeMachine();
                    }
                }
            }
            return _instance;
        }
    }

    public void RemoveAvailability(string beverage)
    {
        if (availability.ContainsKey(beverage) &&
            availability[beverage] >= 1)
        {
            availability[beverage] -= 1;
        }
    }

    //public void AddAvailability(string beverage, int quantity)
    //{

    //}

    public bool CheckAvailability(string beverage)
    {
        if (availability[beverage] > 0)
            return true;
        return false;
    }

    public void Register(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Remove(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in _observers)
            observer.Update(message);
    }
}
