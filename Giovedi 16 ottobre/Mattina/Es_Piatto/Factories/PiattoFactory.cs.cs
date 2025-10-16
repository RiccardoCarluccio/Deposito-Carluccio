using static Es_Piatto.Factories.Piatto;

namespace Es_Piatto.Factories;

public abstract class PiattoFactory
{
    public static IPiatto CreaPiatto(string tipo)
    {
        switch (tipo.Trim().ToLower())
        {
            case "pizza":
                return new Pizza();

            case "hamburger":
                return new Hamburger();

            case "insalata":
                return new Insalata();

            default:
                Console.WriteLine("Tipo non valido");
                return null;
        }
    }
}
