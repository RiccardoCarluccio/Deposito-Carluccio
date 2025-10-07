using EsercizioCorsi.Corsi;

namespace EsercizioCorsi.Estensioni;

public static class Estensioni
{
    public static CorsoMusica AggiungiCorsoMusica(ref int indice)
    {
        indice++;
        Console.WriteLine("Inserisci il nome del corso");
        string NomeCorso = Console.ReadLine()!;
        Console.WriteLine("Inserisci la durata del corso");
        int DurataOre = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Inserisci il docente del corso");
        string Docente = Console.ReadLine()!;
        Console.WriteLine("Inserisci lo strumento musicale del corso");
        string Strumento = Console.ReadLine()!;

        return new CorsoMusica(indice, NomeCorso, DurataOre, Docente, new List<string>(), Strumento);
    }

    public static CorsoPittura AggiungiCorsoPittura(ref int indice)
    {
        indice++;
        Console.WriteLine("Inserisci il nome del corso");
        string NomeCorso = Console.ReadLine()!;
        Console.WriteLine("Inserisci la durata del corso");
        int DurataOre = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Inserisci il docente del corso");
        string Docente = Console.ReadLine()!;
        Console.WriteLine("Inserisci la tecnica su tela");
        string Tecnica = Console.ReadLine()!;

        return new CorsoPittura(indice, NomeCorso, DurataOre, Docente, new List<string>(), Tecnica);
    }

    public static CorsoDanza AggiungiCorsoDanza(ref int indice)
    {
        indice++;
        Console.WriteLine("Inserisci il nome del corso");
        string NomeCorso = Console.ReadLine()!;
        Console.WriteLine("Inserisci la durata del corso");
        int DurataOre = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Inserisci il docente del corso");
        string Docente = Console.ReadLine()!;
        Console.WriteLine("Inserisci lo stile");
        string Stile = Console.ReadLine()!;

        return new CorsoDanza(indice, NomeCorso, DurataOre, Docente, new List<string>(), Stile);
    }

    public static void AggiungiStudente(CorsoBase corso, string nome)
    {
        corso.Studenti.Add(nome);
    }
}
