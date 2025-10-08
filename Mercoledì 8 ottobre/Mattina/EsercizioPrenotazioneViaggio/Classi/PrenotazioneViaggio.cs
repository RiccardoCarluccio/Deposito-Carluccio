namespace EsercizioPrenotazioneViaggio.Classi;

public class PrenotazioneViaggio
{
    int postiPrenotati;
    const int maxPosti = 20;

    public string Destinazione { get; set; }

    int PostiDisponibili
    {
        get { return maxPosti - postiPrenotati; }
    }

    int PostiPrenotati
    {
        get { return postiPrenotati; }
    }

    public PrenotazioneViaggio(string destinazione)
    {
        this.Destinazione = destinazione;
    }

    public void PrenotaPosti(int numero)
    {
        if (numero <= PostiDisponibili)
        {
            postiPrenotati += numero;
            Console.WriteLine($"Sono stati prenotati {numero} posti");
        }
        else
            Console.WriteLine($"I posti liberi sono solo {PostiDisponibili}");

        VisualizzaStato();
    }

    public void AnnullaPrenotazione(int numero)
    {
        if (numero <= postiPrenotati)
        {
            postiPrenotati -= numero;
            Console.WriteLine($"è stata annullata la prenotazione di {numero} posti");
        }
        else
            Console.WriteLine($"I posti occupati sono solo {PostiPrenotati}");

        VisualizzaStato();
    }

    public void VisualizzaStato()
    {
        Console.WriteLine(
            $"Destinazione: {Destinazione}\n" +
            $"Posti disponibili: {PostiDisponibili}\n" +
            $"Posti prenotati: {PostiPrenotati}\n");
    }
}
