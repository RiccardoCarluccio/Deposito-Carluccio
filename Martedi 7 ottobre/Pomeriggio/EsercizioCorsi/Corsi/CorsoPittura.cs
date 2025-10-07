using EsercizioCorsi.Corsi;

public class CorsoPittura : CorsoBase
{
    public string Tecnica;

    public CorsoPittura(int indice,string nomeCorso, int durataOre,
        string docente, List<string> studenti,
        string tecnica)
        : base(indice, nomeCorso, durataOre, docente, studenti)
    {
        this.Tecnica = tecnica;
    }

    public override string ToString()
    {
        return
            $"Indice Corso: {Indice}\n" +
            $"Nome Corso: {NomeCorso}\n" +
            $"Durata Ore: {DurataOre}\n" +
            $"Docente: {Docente}\n" +
            $"Studenti: {string.Join(", ", Studenti)}\n" +
            $"Tecnica: {Tecnica}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si lavora su una tela con tecnica: {Tecnica}\n");
    }
}