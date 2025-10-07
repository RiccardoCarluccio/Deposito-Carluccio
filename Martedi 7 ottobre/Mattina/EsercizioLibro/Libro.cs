namespace EsercizioLibro;

public class Libro
{
    public string Titolo;
    public string Autore;
    public int AnnoPubblicazione;

    public Libro(string titolo, string autore, int annoPubblicazione)
    {
        this.Titolo = titolo;
        this.Autore = autore;
        this.AnnoPubblicazione = annoPubblicazione;
    }

    public override string ToString()
    {
        return $"Titolo: {Titolo}, autore: {Autore}, anno di pubblicazione: {AnnoPubblicazione}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Libro altro)
            return this.Titolo == altro.Titolo
                && this.Autore == altro.Autore
                && this.AnnoPubblicazione == altro.AnnoPubblicazione;
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Titolo, Autore, AnnoPubblicazione);
    }
}
