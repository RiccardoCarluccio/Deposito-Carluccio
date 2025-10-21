public enum TipoTransazione
{
    Acquisto,
    Rimborso,
    Trasferimento
}

public class Extension
{
    public double CalcolaCommissioni(TipoTransazione tipo, double costo)
    {
        double prezzoFinale = 0;

        switch (tipo)
        {
            case TipoTransazione.Acquisto:
                prezzoFinale += costo + (costo * 0.21);
                break;

            case TipoTransazione.Rimborso:
                prezzoFinale = costo;
                break;

            case TipoTransazione.Trasferimento:
                prezzoFinale += costo + (costo * 0.05);
                break;

            default:
                Console.WriteLine("Scelta non valida");
                break;
        }
        return prezzoFinale;
    }
}

class Program
{
    static void Main()
    {
        var calcolatore = new Extension();

        Console.WriteLine("Inserisci il tipo di commissione\n" +
            "1. Acquisto\n" +
            "2. Rimborso\n" +
            "3. Trasferimento");
        int sceltaUtente = int.Parse(Console.ReadLine()!);

        TipoTransazione tipoTransazione = (TipoTransazione)(sceltaUtente - 1);

        Console.WriteLine("Inserisci il costo");
        double costo = double.Parse(Console.ReadLine()!);

        Console.WriteLine(calcolatore.CalcolaCommissioni(tipoTransazione, costo));
    }
}