namespace EsercizioSoldato.Classi;

public class Esercito
{
    private string nazione;

    public string Nazione
    {
        get { return nazione; }
        set { nazione = value; }
    }

    public Esercito(string nazione)
    {
        Nazione = nazione;
    }

    public virtual string ToString()
    {
        return
            $"Nazione: {Nazione}";
    }
}
