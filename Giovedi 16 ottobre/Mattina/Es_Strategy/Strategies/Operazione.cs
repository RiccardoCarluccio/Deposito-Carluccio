namespace Es_Strategy.Strategies;

public interface IStrategiaOperazione
{
    double Calcola(double a, double b);
}

public class SommaStrategiaConcreta : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a + b;
    }
}

public class SottrazioneStrategiaConcreta : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a - b;
    }
}

public class MoltiplicazioneStrategiaConcreta : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a * b;
    }
}

public class DivisioneStrategiaConcreta : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
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

class Program
{
    static void Main()
    {
        var calcolatrice = new Calcolatrice();

        double num1;
        double num2;

        Console.WriteLine("Inserisci 2 numeri\n" +
            "Primo numero:");
        num1 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Secondo numero:");
        num2 = double.Parse(Console.ReadLine()!);

        calcolatrice.ImpostaStrategia(new SommaStrategiaConcreta());
        Console.WriteLine("Somma: ");
        calcolatrice.EseguiOperazione(num1, num2);

        calcolatrice.ImpostaStrategia(new SottrazioneStrategiaConcreta());
        Console.WriteLine("Sottrazione: ");
        calcolatrice.EseguiOperazione(num1, num2);

        calcolatrice.ImpostaStrategia(new MoltiplicazioneStrategiaConcreta());
        Console.WriteLine("Moltiplicazione: ");
        calcolatrice.EseguiOperazione(num1, num2);

        calcolatrice.ImpostaStrategia(new DivisioneStrategiaConcreta());
        Console.WriteLine("Divisione: ");
        calcolatrice.EseguiOperazione(num1, num2);
    }
}