namespace EsercizioOperatore.Classi;

public class OperatoreEmergenza : Operatore
{
    private int livelloUrgenza;

    public int LivelloUrgenza
    {
        get { return livelloUrgenza; }
        set
        {
            if (value >= 1 && value <= 5)
                livelloUrgenza = value;
        }
    }

    public OperatoreEmergenza(string nome, string turno, int livelloUrgenza)
        : base(nome, turno)
    {
        LivelloUrgenza = livelloUrgenza;
    }

    public override string ToString()
    {
        return
            $"Nome: {Nome}\n" +
            $"Turno: {Turno}\n" +
            $"Livello d'emergenza: {LivelloUrgenza}\n";
    }

    public override void EseguiCompito()
    {
        Console.WriteLine($"Gestione emergenza di livello {LivelloUrgenza}");
    }

    public override void EseguiCompito(string nome)
    {
        Console.WriteLine($"L'operatore d'emergenza {Nome} sta gestendo un'emergenza di livello {LivelloUrgenza}");
    }
}
