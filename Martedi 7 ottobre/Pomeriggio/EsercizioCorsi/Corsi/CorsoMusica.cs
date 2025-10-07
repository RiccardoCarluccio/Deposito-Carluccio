using EsercizioCorsi.Corsi;

public class CorsoMusica : CorsoBase
{
    public string Strumento;

    public CorsoMusica(string nomeCorso, int durataOre,
        string docente, List<string> studenti,
        string strumento)
        : base(nomeCorso, durataOre, docente, studenti)
    {
        this.Strumento = strumento;
    }

    public override string ToString()
    {
        return $"Nome Corso: {NomeCorso}\n" +
            $"Durata Ore: {DurataOre}\n" +
            $"Docente: {Docente}\n" +
            $"Studenti: {Studenti}\n" +
            $"Strumento: {Strumento}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si tiene una prova pratica dello strumento: {Strumento}");
    }

    public static CorsoMusica AggiungiCorso()
    {
        Console.WriteLine("Inserisci il nome del corso");
        string NomeCorso = Console.ReadLine()!;
        Console.WriteLine("Inserisci la durata del corso");
        int DurataOre = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Inserisci il docente del corso");
        string Docente = Console.ReadLine()!;
        Console.WriteLine("Inserisci lo strumento musicale del corso");
        string Strumento = Console.ReadLine()!;

        return new CorsoMusica(NomeCorso, DurataOre, Docente, new List<string>(), Strumento);
    }
}