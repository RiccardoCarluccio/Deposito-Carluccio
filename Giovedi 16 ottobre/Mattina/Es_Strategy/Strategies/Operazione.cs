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

class Program
{
    static void Main()
    {
        var calcolatrice = new Calcolatrice();

        double num1;
        double num2;

        int input;
        
        Console.WriteLine("Scegli l'operazione:\n" +
            "1. Addizione\n" +
            "2. Sottrazione\n" +
            "3. Moltiplicazione\n" +
            "4. Divisione\n" +
            "0. Chiudi programma");
        input = int.Parse(Console.ReadLine()!);

        switch (input)
        {
            case 1:
                calcolatrice.ImpostaStrategia(new SommaStrategiaConcreta());
                    
                break;

            case 2:
                calcolatrice.ImpostaStrategia(new SottrazioneStrategiaConcreta());
                    
                break;

            case 3:
                calcolatrice.ImpostaStrategia(new MoltiplicazioneStrategiaConcreta());
                    
                break;

            case 4:
                calcolatrice.ImpostaStrategia(new DivisioneStrategiaConcreta());
                    
                break;

            case 0:
                break;

            default:
                break;
        }

        Console.WriteLine("Inserisci 2 numeri\n" +
            "Primo numero:");
        num1 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Secondo numero:");
        num2 = double.Parse(Console.ReadLine()!);
        
        calcolatrice.EseguiOperazione(num1, num2);
    }
}