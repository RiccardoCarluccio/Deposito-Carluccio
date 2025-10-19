namespace _5_Design_Pattern.Factory.Beverages;

public class Coffee : IBeverage
{
    public void Prepare()
    {
        Console.WriteLine("Your coffee");
    }
}
