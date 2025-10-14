using EsercizioEsame.Classi;

namespace EsercizioEsame.Estensioni;

public static class AggiungiAnimali
{
    public static Pinguino AggiungiPinguino()
    {
        Console.WriteLine("Inserisci il nome del pinguino");
        string nome = Console.ReadLine()!;
        Console.WriteLine("inserisci l'età del pinguino");
        int eta = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Inserisci la velocità massima del pinguino");
        int velocita = int.Parse(Console.ReadLine()!);

        return new Pinguino(nome, eta, velocita);
    }
}
