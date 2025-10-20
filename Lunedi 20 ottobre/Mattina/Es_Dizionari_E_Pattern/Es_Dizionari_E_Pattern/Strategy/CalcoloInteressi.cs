using Es_Dizionari_E_Pattern.Factory;

namespace Es_Dizionari_E_Pattern.Strategy;

public interface ICalcoloInteressi
{
    double CalcolaCosto(IConto conto);
}

public class CalcoloInteressi
{
    private ICalcoloInteressi _strategia;

    public void AggiungiStrategia(ICalcoloInteressi strategia)
    {
        _strategia = strategia;
    }

    public void EseguiStrategia(IConto conto)
    {
        if (_strategia == null)
        {
            Console.WriteLine("Strategia non trovata");
            return;
        }
        _strategia.CalcolaCosto(conto);
    }
}

public class InteressiStandard : ICalcoloInteressi
{
    public double CalcolaCosto(IConto conto)
    {
        var interessi = conto.Costo + conto.Costo * 0.01;
        return interessi;
    }
}

public class InteressiPremium : ICalcoloInteressi
{
    public double CalcolaCosto(IConto conto)
    {
        var interessi = conto.Costo + conto.Costo * 0.03;
        return interessi;
    }
}