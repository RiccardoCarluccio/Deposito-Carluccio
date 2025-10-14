namespace Es_Configurazione;

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

    }

    public string Leggi(string chiave)
    {

    }

    public void StampaTutte()
    {

    }
}
