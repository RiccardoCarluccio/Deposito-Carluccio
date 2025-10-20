namespace Es_Dizionari_E_Pattern.Observer;

public interface ISubject
{
    void Registra(IObserver osservatore);
    void Rimuovi(IObserver osservatore);
    void Notifica(string messaggio);
}
