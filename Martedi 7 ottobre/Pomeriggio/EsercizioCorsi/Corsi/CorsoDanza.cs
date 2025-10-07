using EsercizioCorsi.Corsi;

public class CorsoDanza : CorsoBase
{
    public string Stile;

    public CorsoDanza(int indice, string nomeCorso, int durataOre,
        string docente, List<string> studenti,
        string stile)
        : base(indice, nomeCorso, durataOre, docente, studenti)
    {
        this.Stile = stile;
    }

    public override string ToString()
    {
        return
            $"Indice Corso: {Indice}\n" +
            $"Nome Corso: {NomeCorso}\n" +
            $"Durata Ore: {DurataOre}\n" +
            $"Docente: {Docente}\n" +
            $"Studenti: {string.Join(", ", Studenti)}\n" +
            $"Stile: {Stile}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Esecuzione coreografia nello stile: {Stile}\n");
    }
}