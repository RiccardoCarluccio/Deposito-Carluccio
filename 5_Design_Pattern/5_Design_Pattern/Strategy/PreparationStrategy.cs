using _5_Design_Pattern.Factory;

namespace _5_Design_Pattern.Strategy;

public interface IPreparationStrategy
{
    void Serve(IBeverage beverage);
}

public class PreparationStrategy
{
    private IPreparationStrategy _strategy;

    public void SetStrategy(IPreparationStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecuteStrategy(IBeverage beverage)
    {
        if (_strategy == null)
        {
            Console.WriteLine("Strategy not set");
            return;
        }
        _strategy.Serve(beverage);
    }
}

public class HotPreparation : IPreparationStrategy
{
    public void Serve(IBeverage beverage)
    {
        beverage.Prepare();
        Console.WriteLine($"Will be served hot");
    }
}

public class ColdPreparation : IPreparationStrategy
{
    public void Serve(IBeverage beverage)
    {
        beverage.Prepare();
        Console.WriteLine($"Will be served cold");
    }
}
