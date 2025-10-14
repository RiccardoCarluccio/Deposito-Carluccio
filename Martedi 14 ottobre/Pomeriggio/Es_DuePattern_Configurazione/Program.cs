using Es_DuePattern_Configurazione.Factories;
using Es_DuePattern_Configurazione.Interfacce;
using Es_DuePattern_Configurazione.Singleton;

public class ModuloA
{
    public void Esegui()
    {
        var config = ConfigurazioneSistema.Instance;
        config.Imposta("tema", "scuro");
        Console.WriteLine($"[ModuloA] tema = {config.Leggi("tema")}");
    }
}

public class ModuloB
{
    public void Esegui()
    {
        var config = ConfigurazioneSistema.Instance;
        config.Imposta("lingua", "it-IT");
        Console.WriteLine($"[ModuloB] lingua = {config.Leggi("lingua")}");
    }
}

class Program
{
    static void Main()
    {
        var a = new ModuloA();
        var b = new ModuloB();
        a.Esegui();
        b.Esegui();
        Console.WriteLine("Stessa istanza? " +
            Object.ReferenceEquals(ConfigurazioneSistema.Instance, ConfigurazioneSistema.Instance));
        ConfigurazioneSistema.Instance.StampaTutte();
        Console.WriteLine();

        string sceltaDispositivo;
        do
        {
            Console.WriteLine("Seleziona il dispositivo da aggiungere:\n" +
                "Computer, Stampante\n" +
                "'Fine' per terminare il programma");

            sceltaDispositivo = Console.ReadLine()!;

            if (sceltaDispositivo.ToLower() != "fine")
            {
                IDispositivo dispositivo = DispositivoFactory.CreaDispositivo(sceltaDispositivo);

                Console.WriteLine("Scegli la specifica da configurare");
                string chiave = Console.ReadLine()!;

                Console.WriteLine("Scegli il suo valore");
                string valore = Console.ReadLine()!;

                ConfigurazioneSistema.Instance.Imposta(chiave, valore);

                if (dispositivo != null)
                {
                    dispositivo.Avvia();
                    dispositivo.MostraTipo();
                }
                else
                    Console.WriteLine("Dispositivo non valido");

                ConfigurazioneSistema.Instance.StampaTutte();
            }
            else
                Console.WriteLine("Chiusura del programma");
        }
        while (sceltaDispositivo.ToLower() != "fine");
    }
}