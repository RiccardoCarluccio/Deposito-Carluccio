using Es_DuePattern_Configurazione.Interfacce;
using static Es_DuePattern_Configurazione.Classi.Dispositivi;

namespace Es_DuePattern_Configurazione.Factories;

public abstract class DispositivoFactory
{
    public static IDispositivo CreaDispositivo(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "computer":
                return new Computer();

            case "stampante":
                return new Stampante();

            default:
                Console.WriteLine("Tipo non valido");
                return null;
        }
    }
}
