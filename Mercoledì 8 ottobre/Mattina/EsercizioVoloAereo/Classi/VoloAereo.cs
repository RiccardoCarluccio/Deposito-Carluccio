namespace EsercizioVoloAereo.Classi;

public class VoloAereo
{
    private int postiOccupati;
    private const int MaxPosti = 150;
    public int CodiceVolo { get; set; }
    public int PostiOccupati
    {
        get { return postiOccupati; }
    }
    public int PostiLiberi
    {
        get { return MaxPosti - postiOccupati; }
    }

    public VoloAereo(int postiOccupati, int codiceVolo)
    {
        this.postiOccupati = postiOccupati;
        this.CodiceVolo = codiceVolo;
    }

    public void EffettuaPrenotazioni(int numeroPosti)
    {
        if (numeroPosti <= PostiLiberi && numeroPosti + PostiOccupati <= 150)
        {
            postiOccupati += numeroPosti;
            Console.WriteLine($"Sono stati prenotati {numeroPosti} posti");
        }
        else
            Console.WriteLine($"I posti liberi sono solo {PostiLiberi}");

        VisualizzaStato();
    }

    public void AnnullaPrenotazione(int numeroPosti)
    {
        if (numeroPosti <= PostiOccupati && numeroPosti + PostiLiberi <= 150)
        {
            postiOccupati -= numeroPosti;
            Console.WriteLine($"è stata annullata la prenotazione di {numeroPosti} posti");
        }
        else
            Console.WriteLine($"I posti occupati sono solo {PostiOccupati}");

        VisualizzaStato();
    }

    public void VisualizzaStato()
    {
        Console.WriteLine(
            $"Codice volo: {CodiceVolo}\n" +
            $"Posti occupati: {PostiOccupati}\n" +
            $"Posti liberi: {PostiLiberi}\n");
    }
}
