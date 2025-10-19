using _5_Design_Pattern.Factory;

namespace _5_Design_Pattern.Decorator;

public abstract class BeverageDecorator : IBeverage
{
    protected IBeverage _beverage;

    protected BeverageDecorator(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public virtual void Prepare()
    {
        _beverage.Prepare();
    }
}
