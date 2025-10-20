using Es_Dizionari_E_Pattern.Factory.Conti;

namespace Es_Dizionari_E_Pattern.Factory;

public class ContoFactory
{
    public static IConto? ApriConto(string type)
    {
        switch (type.Trim().ToLower())
        {
            case "base":
                return new ContoBase();

            case "premium":
                return new ContoPremium();

            case "studente":
                return new ContoStudente();

            default:
                Console.WriteLine("Input non valido");
                return null;
        }
    }
}
