namespace Es_Strategy.Strategies;

public interface IStrategiaOperazione
{
    double Calcola(double a, double b);
}

public class SommaStrategiaConcreta : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        Console.WriteLine("Somma: ");
        return a + b;
    }
}

public class SottrazioneStrategiaConcreta : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        Console.WriteLine("Sottrazione: ");
        return a - b;
    }
}

public class MoltiplicazioneStrategiaConcreta : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        Console.WriteLine("Moltiplicazione: ");
        return a * b;
    }
}

public class DivisioneStrategiaConcreta : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        Console.WriteLine("Divisione: ");
        if (b == 0)
            throw new NotImplementedException();
        return a / b;
    }
}

public class Calcolatrice
{
    private IStrategiaOperazione _strategia;

    public void ImpostaStrategia(IStrategiaOperazione strategia)
    {
        _strategia = strategia;
    }

    public void EseguiOperazione(double a, double b)
    {
        if (_strategia == null)
        {
            Console.WriteLine("Nessuna strategia impostata");
            return;
        }
        double result = _strategia.Calcola(a, b);
        Console.WriteLine($"Risultato dell'operazione: {result}");
    }
}