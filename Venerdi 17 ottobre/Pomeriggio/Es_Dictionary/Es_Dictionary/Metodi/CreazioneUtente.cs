using Es_Dictionary.Classi;
using Es_Dictionary.Singleton;

namespace Es_Dictionary.Metodi;

public static class CreazioneUtente
{
    public static Utente CreaUtente()
    {
        Console.WriteLine("Aggiungi le informazioni dell'utente da aggiungere\n" +
                "Username:");
        string username = Console.ReadLine()!;
        Console.WriteLine("email:");
        string email = Console.ReadLine()!;
        Console.WriteLine("Stato:");

        Stato statoUtente;
        string stato = Console.ReadLine()!.Trim().ToLower();
        if (stato == "attivo")
            statoUtente = Stato.Attivo;
        else if (stato == "inattivo")
            statoUtente = Stato.Inattivo;
        else
            statoUtente = Stato.Invalid;    //TODO. Migliorare il check e non permettere "invalid"

        DateTimeOffset dataCreazione = DateTimeOffset.UtcNow;

        return new Utente(0, username, email, dataCreazione, statoUtente);
    }
}
