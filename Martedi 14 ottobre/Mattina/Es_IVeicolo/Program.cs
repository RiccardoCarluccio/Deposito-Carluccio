public interface IVeicolo
{
    void Avvia();
    void MostraTipo();
}

public class Auto : IVeicolo
{
    public void Avvia()
    {
        Console.WriteLine("Avvio dell'auto");
    }

    public void MostraTipo()
    {
        Console.WriteLine("Tipo: Auto");
    }
}

public class Moto : IVeicolo
{
    public void Avvia()
    {
        Console.WriteLine("Avvio della moto");
    }

    public void MostraTipo()
    {
        Console.WriteLine("Tipo: Moto");
    }
}

public class Camion : IVeicolo
{
    public void Avvia()
    {
        Console.WriteLine("Avvio del camion");
    }

    public void MostraTipo()
    {
        Console.WriteLine("Tipo: Camion");
    }
}

public abstract class VeicoloFactory
{
    public static IVeicolo CreaVeicolo(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "auto":
                return new Auto();

            case "moto":
                return new Moto();

            case "camion":
                return new Camion();

            default:
                Console.WriteLine("Tipo non valido");
                return null;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleziona il veicolo da creare");
        string input = Console.ReadLine()!;

        IVeicolo veicolo = VeicoloFactory.CreaVeicolo(input);

        if (veicolo != null)
        {
            veicolo.Avvia();
            veicolo.MostraTipo();
        }
        else
        {
            Console.WriteLine("Veicolo non valido");
        }
    }
}