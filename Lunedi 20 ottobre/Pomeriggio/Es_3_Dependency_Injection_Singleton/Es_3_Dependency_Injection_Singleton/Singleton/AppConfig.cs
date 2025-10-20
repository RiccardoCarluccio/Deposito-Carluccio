namespace Es_3_Dependency_Injection_Singleton.Singleton;

public sealed class AppConfig
{
    private static AppConfig _instance;

    private static object _lock = new object();

    private string _nomeApp;
    private string _valuta;
    private double _aliquotaIva;

    public string NomeApp
    {
        get { return _nomeApp; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                _nomeApp = value;
        }
    }

    public string Valuta
    {
        get { return _valuta; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                _valuta = value;
        }
    }

    public double AliquotaIva
    {
        get { return _aliquotaIva; }
        set
        {
            if (value > 0)
                _aliquotaIva = value;
        }
    }

    private AppConfig() { }

    public static AppConfig Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new AppConfig();
                    }
                }
            }
            return _instance;
        }
    }
}
