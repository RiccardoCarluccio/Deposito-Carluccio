using Es_Dizionari_E_Pattern.Entita;
using Es_Dizionari_E_Pattern.Observer;
using System;

namespace Es_Dizionari_E_Pattern.Singleton;

public sealed class BankContext : ISubject
{
    private static BankContext _instance;
    
    private static object _lock = new object();

    private int _idUtente = 1;
    private int _idConto = 1;

    private readonly Dictionary<int, Cliente> listaClienti = new();
    private readonly Dictionary<int, ContoCorrente> listaContiCorrente = new();
    private readonly Dictionary<int, List<OperazioniConto>> listaOperazioniConto = new();

    private readonly List<IObserver> _osservatori = new();

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
        listaClienti.Add(_idUtente++, cliente);
    }

    public void RimuoviCliente(int id)
    {
        if (listaClienti.ContainsKey(id))
            listaClienti.Remove(id);
        else
            Console.WriteLine("Cliente non trovato");
    }

    public void AggiungiConto(ContoCorrente conto)
    {
        listaContiCorrente.Add(_idConto++, conto);
    }

    public void RimuoviConto(int id)
    {
        if (listaContiCorrente.ContainsKey(id))
            listaContiCorrente.Remove(id);
        else
            Console.WriteLine("Conto non trovato");
    }

    public void AggiungiOperazione(int id, ContoCorrente conto)
    {
        //TODO
    }

    public void Registra(IObserver osservatore)
    {
        _osservatori.Add(osservatore);
    }

    public void Rimuovi(IObserver osservatore)
    {
        _osservatori.Remove(osservatore);
    }

    public void Notifica(string messaggio)
    {
        foreach (var osservatore in _osservatori)
            osservatore.Aggiorna(messaggio);
    }
}
