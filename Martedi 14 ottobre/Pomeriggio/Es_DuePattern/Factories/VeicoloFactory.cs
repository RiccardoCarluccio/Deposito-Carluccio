using Es_DuePattern.Interfacce;
using static Es_DuePattern.Classi.Veicoli;

namespace Es_DuePattern.Factories;

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