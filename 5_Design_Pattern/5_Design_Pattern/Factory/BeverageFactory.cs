using _5_Design_Pattern.Factory.Beverages;

namespace _5_Design_Pattern.Factory;

public abstract class BeverageFactory
{
    public static IBeverage? MakeBeverage(string type)
    {
        switch(type.Trim().ToLower())
        {
            case "tea":
                return new Tea();

            case "coffee":
                return new Coffee();

            default:
                Console.WriteLine("Invalid input");     //ridondante?
                return null;
        }
    }
}
