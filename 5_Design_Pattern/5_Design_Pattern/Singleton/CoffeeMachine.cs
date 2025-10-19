namespace _5_Design_Pattern.Singleton;

public sealed class CoffeeMachine
{
    private static CoffeeMachine _instance;

    private static object _lock = new object();

    private readonly Dictionary<string, int> availability = new()
    {
        { "Tea", 1 },
        { "Coffee", 1 }
    };

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
}
