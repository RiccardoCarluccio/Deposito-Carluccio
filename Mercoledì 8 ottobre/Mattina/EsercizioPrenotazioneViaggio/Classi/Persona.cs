namespace EsercizioPrenotazioneViaggio.Classi;

public class Persona
{
    public string Nome { get; set; }

    public Persona(string nome)
    {
        this.Nome = nome;
    }

    public void Prenota(PrenotazioneViaggio viaggio, int postiDaPrenotare)
    {
        if (postiDaPrenotare <= viaggio.PostiDisponibili)
        {
            viaggio.PrenotaPosti(postiDaPrenotare);
            Console.WriteLine($"{Nome} ha prenotato {postiDaPrenotare} posti per {viaggio.Destinazione}");
        }
        else
            Console.WriteLine($"I posti liberi sono solo {viaggio.PostiDisponibili}");
    }
}
