using Es_DuePattern.Interfacce;

namespace Es_DuePattern.Singleton;

public sealed class RegistroVeicoli
{
    private static RegistroVeicoli _instance;
    
    private static object _lock = new object();

    private readonly List<IVeicolo> veicoliCreati = [];

    private RegistroVeicoli()
    {

    }

    public static RegistroVeicoli Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new RegistroVeicoli();
                    }
                }
            }
            return _instance;
        }
    }

    public void Registra(IVeicolo veicolo)
    {
        veicoliCreati.Add(veicolo);
    }

    public void StampaTutti()
    {
        foreach (var veicolo in veicoliCreati)
            Console.WriteLine($"{veicolo.GetType().Name}");
    }
}
