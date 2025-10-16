namespace Es_Strategy.Singleton;

public sealed class RegistroUtenti
{
    private static RegistroUtenti _instance;

    private static object _lock = new object();

    private readonly List<string> utenti = new();

    private RegistroUtenti()
    {

    }

    public static RegistroUtenti Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new RegistroUtenti();
                    }
                }
            }
            return _instance;
        }
    }

    public void Registra(string name)
    {
        utenti.Add(name);
    }

    public void StampaTutti()
    {
        foreach (var utente in utenti)
            Console.WriteLine(utente);
    }
}
