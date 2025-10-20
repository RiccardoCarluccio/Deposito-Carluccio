namespace Es_Dizionari_E_Pattern.Factory.Conti;

public class ContoStudente : IConto
{
    private double _costo = 2;

    public double Costo
    {
        get { return _costo; }
        init { _costo = value; }
    }

    public void Subscribe()
    {
        Console.WriteLine("Sottoscrizione al conto Studenti");
    }
}
