using EsercizioOperatore.Classi;

namespace EsercizioOperatore.Estensioni;

public static class AggiungiOperatore
{
    /// <summary>
    /// Richiede una string nome, string turno di lavoro e int livello di urgenza, da console
    /// </summary>
    public static OperatoreEmergenza AggiungiOperatoreEmergenza()
    {
        Console.WriteLine("Inserisci il nome dell'operatore");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Inserisci il turno dell'operatore");
        string turno = Console.ReadLine()!;
        Console.WriteLine("Inserisci il livello d'emergenza dell'operatore (da 1 a 5)");
        int livelloUrgenza = int.Parse(Console.ReadLine()!);

        return new OperatoreEmergenza(nome, turno, livelloUrgenza);
    }

    public static OperatoreSicurezza AggiungiOperatoreSicurezza()
    {
        Console.WriteLine("Inserisci il nome dell'operatore");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Inserisci il turno dell'operatore");
        string turno = Console.ReadLine()!;
        Console.WriteLine("Inserisci l'area sorvegliata dell'operatore");
        string areaSorvegliata = Console.ReadLine()!;

        return new OperatoreSicurezza(nome, turno, areaSorvegliata);
    }

    public static OperatoreLogistica AggiungiOperatoreLogistica()
    {
        Console.WriteLine("Inserisci il nome dell'operatore");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Inserisci il turno dell'operatore");
        string turno = Console.ReadLine()!;
        Console.WriteLine("Inserisci il numero di consegne dell'operatore (minimo 0)");
        int numeroConsegne = int.Parse(Console.ReadLine()!);

        return new OperatoreLogistica(nome, turno, numeroConsegne);
    }
}
