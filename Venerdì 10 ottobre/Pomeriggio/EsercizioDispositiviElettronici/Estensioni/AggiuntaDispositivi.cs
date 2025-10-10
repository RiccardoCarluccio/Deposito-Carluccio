using EsercizioDispositiviElettronici.Classi;

namespace EsercizioDispositiviElettronici.Estensioni;

public static class AggiuntaDispositivi
{
    public static Computer AggiungiComputer()
    {
        Console.WriteLine("Inserisci il modello");
        string modello = Console.ReadLine()!;

        return new Computer(modello);
    }

    public static Stampante AggiungiStampante()
    {
        Console.WriteLine("Inserisci il modello");
        string modello = Console.ReadLine()!;

        return new Stampante(modello);
    }
}
