namespace Es_DuePattern_Configurazione.Singleton;

public sealed class ConfigurazioneSistema
{
    private static ConfigurazioneSistema _instance;

    private static object _lock = new object();

    private readonly Dictionary<string, string> config = [];

    private ConfigurazioneSistema()
    {

    }

    public static ConfigurazioneSistema Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigurazioneSistema();
                    }
                }
            }
            return _instance;
        }
    }

    public void Imposta(string chiave, string valore)
    {
        config[chiave] = valore;
    }

    public string Leggi(string chiave)
    {
        if (config.TryGetValue(chiave, out string? valore))
        {
            return $"{chiave}: {valore}";
        }
        else
            return "Chiave non trovata";
    }

    public void StampaTutte()
    {
        foreach (var kvp in config)
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
}
