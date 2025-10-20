namespace Es_Dizionari_E_Pattern.Factory.Conti;

public class ContoBase : IConto
{
    private double _costo = 5;

    public double Costo
    {
        get { return _costo; }
        init { _costo = value; }
    }

    public void Subscribe()
    {
        Console.WriteLine("Sottoscrizione al conto base");
    }
}
