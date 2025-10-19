namespace _5_Design_Pattern.Factory.Beverages;

public class Tea : IBeverage
{
    public void Prepare()
    {
        Console.WriteLine("Your tea");
    }
}
