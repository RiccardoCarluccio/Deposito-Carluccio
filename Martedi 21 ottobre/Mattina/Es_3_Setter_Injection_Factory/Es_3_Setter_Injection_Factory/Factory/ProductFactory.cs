using static Es_3_Setter_Injection_Factory.Factory.Products;

namespace Es_3_Setter_Injection_Factory.Factory;

public abstract class ProductFactory
{
    public static IProduct? OrderBook(string type)
    {
        switch (type.Trim().ToLower())
        {
            case "printed":
                return new PrintedBook();

            case "digital":
                return new DigitalBook();

            default:
                Console.WriteLine("Invalid type");
                return null;
        }
    }
}