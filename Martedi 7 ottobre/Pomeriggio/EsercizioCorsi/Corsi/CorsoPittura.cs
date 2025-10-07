using EsercizioCorsi.Corsi;

public class CorsoPittura : CorsoBase
{
    public string Tecnica;

    public CorsoPittura(string nomeCorso, int durataOre,
        string docente, List<string> studenti,
        string tecnica)
        : base(nomeCorso, durataOre, docente, studenti)
    {
        this.Tecnica = tecnica;
    }

    public override string ToString()
    {
        return $"Nome Corso: {NomeCorso}\n" +
            $"Durata Ore: {DurataOre}\n" +
            $"Docente: {Docente}\n" +
            $"Studenti: {Studenti}\n" +
            $"Tecnica: {Tecnica}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si lavora su una tela con tecnica: {Tecnica}");
    }
}