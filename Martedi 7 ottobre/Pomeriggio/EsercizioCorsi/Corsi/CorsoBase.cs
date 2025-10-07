namespace EsercizioCorsi.Corsi;

public class CorsoBase
{
    public string NomeCorso;
    public int DurataOre;
    public string Docente;
    public List<string> Studenti;

    public CorsoBase(string nomeCorso, int durataOre,
        string docente, List<string> studenti)
    {
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
        return $"Nome Corso: {NomeCorso}\n" +
            $"Durata Ore: {DurataOre}\n" +
            $"Docente: {Docente}\n" +
            $"Studenti: {Studenti}\n";
    }

    public virtual void MetodoSpeciale()
    {

    }

    //public virtual CorsoBase AggiungiCorso()
    //{
    //    Console.WriteLine("Inserisci il nome del corso");
    //    NomeCorso = Console.ReadLine()!;
    //    Console.WriteLine("Inserisci la durata del corso");
    //    DurataOre = int.Parse(Console.ReadLine()!);
    //    Console.WriteLine("Inserisci il docente del corso");
    //    Docente = Console.ReadLine()!;

    //    return new CorsoBase(NomeCorso, DurataOre, Docente, Studenti);
    //}
}