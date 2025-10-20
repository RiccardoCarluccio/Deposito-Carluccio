namespace Es_Dizionari_E_Pattern.Observer;

public class Observers
{
    public class EmailObserver : IObserver
    {
        public void Aggiorna(string messaggio)
        {
            Console.WriteLine($"[Email]: {messaggio}");
        }
    }

    public class MobileObserver : IObserver
    {
        public void Aggiorna(string messaggio)
        {
            Console.WriteLine($"[Mobile]: {messaggio}");
        }
    }
}
