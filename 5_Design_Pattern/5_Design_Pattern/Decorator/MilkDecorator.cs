using _5_Design_Pattern.Factory;

namespace _5_Design_Pattern.Decorator;

public class MilkDecorator : BeverageDecorator
{
    public MilkDecorator(IBeverage beverage)
        : base(beverage)
    { }

    public override void Prepare()
    {
        base.Prepare();
        Console.WriteLine("Plus milk");
    }
}
