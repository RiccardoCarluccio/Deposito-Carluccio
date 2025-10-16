public interface IObserver      //ascolta notifiche dal subject
{
    void Aggiorna(string messaggio);        //Aggiorna => "Ricevi aggiornamento" o "Ricevi notifica"
}

public interface ISoggetto      //chi invia la notifica - Observed
{
    void Registra(IObserver osservatore);
    void Rimuovi(IObserver osservatore);
    void Notifica(string messaggio);
}

//classe concreta
public class CentroMeteo : ISoggetto
{
    private readonly List<IObserver> _osservatori = [];

    public void Registra(IObserver osservatore)
    {
        _osservatori.Add(osservatore);
    }

    public void Rimuovi(IObserver osservatore)
    {
        _osservatori.Remove(osservatore);
    }

    public void Notifica(string messaggio)              //invia la notifica. Il suo ruolo è selezionare gli osservatori a cui far ricevere la notifica
    {
        foreach (var osservatore in _osservatori)
        {
            osservatore.Aggiorna(messaggio);            //ricevi notifica
        }
    }

    public void AggiornaMeteo(string dati)
    {
        Console.WriteLine($"Aggiornamento: {dati}");
        Notifica(dati);
    }
}

public class DisplayConsole : IObserver
{
    public void Aggiorna(string messaggio)              //riceve notifica
    {
        Console.WriteLine($"Aggiornamento console: {messaggio}");
    }
}

public class DisplayMobile : IObserver
{
    public void Aggiorna(string messaggio)
    {
        Console.WriteLine($"Aggiornamento mobile: {messaggio}");
    }
}

class Program
{
    static void Main()
    {
        var centro = new CentroMeteo();

        IObserver consoleDisplay = new DisplayConsole();
        IObserver mobileDisplay = new DisplayMobile();

        centro.Registra(consoleDisplay);
        centro.Registra(mobileDisplay);

        string input;
        do
        {
            Console.WriteLine("Inserisci un dato meteo. Scrivi 'Fine' per terminare");
            input = Console.ReadLine()!;

            if (input.ToLower() != "fine")
                centro.AggiornaMeteo(input);
            else
                Console.WriteLine("Fine programma");
        }
        while (input.ToLower() != "fine");
    }
}