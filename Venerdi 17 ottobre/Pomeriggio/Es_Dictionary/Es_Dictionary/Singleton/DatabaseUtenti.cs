using Es_Dictionary.Classi;

namespace Es_Dictionary.Singleton;

public sealed class DatabaseUtenti
{
    private static DatabaseUtenti _instance;

    private static object _lock = new object();

    private readonly Dictionary<int, Utente> utenti = [];

    private int id = 0;

    private DatabaseUtenti()
    {

    }

    public static DatabaseUtenti Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseUtenti();
                    }
                }
            }
            return _instance;
        }
    }

    public void AggiungiUtente(Utente utente)
    {
        id++;
        utenti.Add(id, utente);
    }

    public void RimuoviUtente(int id)
    {
        if (utenti.ContainsKey(id))
            utenti.Remove(id);
        else
            Console.WriteLine($"Utente con id: {id} non trovato");
    }

    public void VisualizzaUtenti()
    {
        foreach (var kvp in utenti)
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }

    public int PrendiUltimoId()
    {
        return utenti.Keys.Max();
    }
}
