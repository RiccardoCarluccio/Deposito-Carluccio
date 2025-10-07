using EsercizioCorsi.Corsi;

public class CorsoDanza : CorsoBase
{
    public string Stile;

    public CorsoDanza(string nomeCorso, int durataOre,
        string docente, List<string> studenti,
        string stile)
        : base(nomeCorso, durataOre, docente, studenti)
    {
        this.Stile = stile;
    }

    public override string ToString()
    {
        return $"Nome Corso: {NomeCorso}\n" +
            $"Durata Ore: {DurataOre}\n" +
            $"Docente: {Docente}\n" +
            $"Studenti: {Studenti}\n" +
            $"Stile: {Stile}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Esecuzione coreografia nello stile: {Stile}");
    }
}