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

public interface INave
{
    void Avvia();
    void MostraTipo();
}

public class BarcaAVela : INave
{
    public void Avvia()
    {
        Console.WriteLine("Alza le vele");
    }

    public void MostraTipo()
    {
        Console.WriteLine("Tipo: barca a vela");
    }
}

public class BarcaAMotore : INave
{
    public void Avvia()
    {
        Console.WriteLine("Accendi il motore");
    }

    public void MostraTipo()
    {
        Console.WriteLine("Tipo: barca a motore");
    }
}

public abstract class NaveFactory
{
    public static INave CreaNave(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "vela":
                return new BarcaAVela();

            case "motore":
                return new BarcaAMotore();

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
        Console.WriteLine("Seleziona il mezzo da creare:\n" +
            "1. Veicolo\n" +
            "2. Nave\n");

        int input = int.Parse(Console.ReadLine()!);

        switch (input)
        {
            case 1:
                Console.WriteLine("Seleziona il veicolo da creare:\n" +
                    "Auto, Moto, Camion");

                string sceltaVeicolo = Console.ReadLine()!;
                IVeicolo veicolo = VeicoloFactory.CreaVeicolo(sceltaVeicolo);

                if (veicolo != null)
                {
                    veicolo.Avvia();
                    veicolo.MostraTipo();
                }
                else
                {
                    Console.WriteLine("Veicolo non valido");
                }
                break;

            case 2:
                Console.WriteLine("Seleziona la nave da creare:\n" +
                    "Vela, Motore");

                string sceltaNave = Console.ReadLine()!;
                INave nave = NaveFactory.CreaNave(sceltaNave);

                if (nave != null)
                {
                    nave.Avvia();
                    nave.MostraTipo();
                }
                else
                {
                    Console.WriteLine("Nave non valida");
                }
                break;

        }
    }
}