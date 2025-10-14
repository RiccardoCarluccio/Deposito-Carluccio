namespace EsercizioCorsoFormativo.ClassiAstratte;

public abstract class Corso
{
    private string _titolo;
    private int _durataOre;

    public string Titolo
    {
        get { return _titolo; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                _titolo = value;
        }
    }

    public int DurataOre
    {
        get { return _durataOre; }
        set
        {
            if (value > 0)
                _durataOre = value;
        }
    }

    public Corso(string titolo, int durataOre)
    {
        Titolo = titolo;
        DurataOre = durataOre;
    }

    public abstract void ErogaCorso();

    public abstract void StampaDettagli();

    public abstract void StampaDettagli(Corso corso);
}
