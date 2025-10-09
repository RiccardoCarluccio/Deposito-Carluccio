using EsercizioOperatore.Classi;

namespace EsercizioOperatore.Estensioni;

public static class AggiungiOperatore
{
    public static OperatoreEmergenza AggiungiOperatoreEmergenza()
    {
        Console.WriteLine("Inserisci il nome dell'operatore");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Inserisci il turno dell'operatore");
        string turno = Console.ReadLine()!;
        Console.WriteLine("Inserisci il livello d'emergenza dell'operatore");
        int livelloUrgenza = int.Parse(Console.ReadLine()!);

        return new OperatoreEmergenza(nome, turno, livelloUrgenza);
    }

    public static OperatoreSicurezza AggiungiOperatoreSicurezza()
    {
        Console.WriteLine("Inserisci il nome dell'operatore");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Inserisci il turno dell'operatore");
        string turno = Console.ReadLine()!;
        Console.WriteLine("Inserisci il livello d'emergenza dell'operatore");
        string areaSorvegliata = Console.ReadLine()!;

        return new OperatoreSicurezza(nome, turno, areaSorvegliata);
    }

    public static OperatoreLogistica AggiungiOperatoreLogistica()
    {
        Console.WriteLine("Inserisci il nome dell'operatore");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Inserisci il turno dell'operatore");
        string turno = Console.ReadLine()!;
        Console.WriteLine("Inserisci il livello d'emergenza dell'operatore");
        int numeroConsegne = int.Parse(Console.ReadLine()!);

        return new OperatoreLogistica(nome, turno, numeroConsegne);
    }
}
