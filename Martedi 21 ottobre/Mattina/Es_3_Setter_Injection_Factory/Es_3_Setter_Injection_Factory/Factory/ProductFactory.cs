using static Es_3_Setter_Injection_Factory.Factory.Products;

namespace Es_3_Setter_Injection_Factory.Factory;

public abstract class ProductFactory
{
    public static IProduct? OrderBook(string type)
    {
        switch (type.Trim().ToLower())
        {
            case "fisico":
                return new PrintedBook();

            case "digitale":
                return new DigitalBook();

            default:
                Console.WriteLine("Tipo di libro non valido");
                return null;
        }
    }
}