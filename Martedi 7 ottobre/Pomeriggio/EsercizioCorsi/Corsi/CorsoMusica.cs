using EsercizioCorsi.Corsi;

public class CorsoMusica : CorsoBase
{
    public string Strumento;

    public CorsoMusica(int indice, string nomeCorso, int durataOre,
        string docente, List<string> studenti,
        string strumento)
        : base(indice, nomeCorso, durataOre, docente, studenti)
    {
        this.Strumento = strumento;
    }

    public override string ToString()
    {
        return
            $"Indice Corso: {Indice}\n" +
            $"Nome Corso: {NomeCorso}\n" +
            $"Durata Ore: {DurataOre}\n" +
            $"Docente: {Docente}\n" +
            $"Studenti: {string.Join(", ", Studenti)}\n" +
            $"Strumento: {Strumento}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si tiene una prova pratica dello strumento: {Strumento}\n");
    }
}