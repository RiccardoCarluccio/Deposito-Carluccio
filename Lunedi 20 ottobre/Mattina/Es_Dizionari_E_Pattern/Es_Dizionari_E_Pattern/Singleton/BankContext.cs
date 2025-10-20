using Es_Dizionari_E_Pattern.Entita;

namespace Es_Dizionari_E_Pattern.Singleton;

public sealed class BankContext
{
    private static BankContext _instance;
    
    private static object _lock = new object();

    private int _idIncrementale = 1;

    private readonly Dictionary<int, Cliente> listaClienti = new();

    private readonly Dictionary<int, ContoCorrente> listaContiCorrente = new();

    private BankContext() { }

    public static BankContext Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new BankContext();
                    }
                }
            }
            return _instance;
        }
    }

    public void AggiungiCliente(Cliente cliente)
    {
        listaClienti.Add(_idIncrementale++, cliente);
    }

    public void RimuoviCliente(int id)
    {

    }
}
