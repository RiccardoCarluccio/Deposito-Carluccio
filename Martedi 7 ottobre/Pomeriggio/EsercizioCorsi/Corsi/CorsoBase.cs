namespace EsercizioCorsi.Corsi;

public class CorsoBase
{
    public int Indice;

    public string NomeCorso;
    public int DurataOre;
    public string Docente;
    public List<string> Studenti;

    public CorsoBase(int indice, string nomeCorso, int durataOre,
        string docente, List<string> studenti)
    {
        this.Indice = indice;
        this.NomeCorso = nomeCorso;
        this.DurataOre = durataOre;
        this.Docente = docente;
        this.Studenti = studenti;
    }

    public void AggiungiStudente(string nomeStudente)
    {
        Studenti.Add(nomeStudente);
    }

    public virtual string ToString()
    {
        return
            $"Indice Corso: {Indice}\n" +
            $"Nome Corso: {NomeCorso}\n" +
            $"Durata Ore: {DurataOre}\n" +
            $"Docente: {Docente}\n" +
            $"Studenti: {string.Join(", ", Studenti)}\n";
    }

    public virtual void MetodoSpeciale()
    {

    }
}