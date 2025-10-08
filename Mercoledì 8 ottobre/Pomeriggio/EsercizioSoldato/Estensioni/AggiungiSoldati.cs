using EsercizioSoldato.Classi;

namespace EsercizioSoldato.Estensioni;

public static class AggiungiSoldati
{
    public static Fante AggiungiFante()
    {
        Console.WriteLine("Inserisci il nome del soldato");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Inserisci il grado del soldato");
        string grado = Console.ReadLine()!;
        Console.WriteLine("Inserisci gli anni di servizio");
        int anniServizio = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Inserisci l'arma");
        string arma = Console.ReadLine()!;

        return new Fante(nome, grado, anniServizio, arma);
    }

    public static Artigliere AggiungiArtigliere()
    {
        Console.WriteLine("Inserisci il nome del soldato");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Inserisci il grado del soldato");
        string grado = Console.ReadLine()!;
        Console.WriteLine("Inserisci gli anni di servizio");
        int anniServizio = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Inserisci l'arma");
        int calibro = int.Parse(Console.ReadLine()!);

        return new Artigliere(nome, grado, anniServizio, calibro);
    }
}
