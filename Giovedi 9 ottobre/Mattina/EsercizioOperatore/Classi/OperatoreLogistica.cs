namespace EsercizioOperatore.Classi;

public class OperatoreLogistica : Operatore
{
    private int numeroConsegne;

    public int NumeroConsegne
    {
        get { return numeroConsegne; }
        set
        {
            if (value >= 0)
                numeroConsegne = value;
        }
    }

    public OperatoreLogistica(string nome, string turno, int numeroConsegne)
        : base(nome, turno)
    {
        NumeroConsegne = numeroConsegne;
    }

    public override string ToString()
    {
        return
            $"Nome: {Nome}\n" +
            $"Turno: {Turno}\n" +
            $"Numero di consegne: {NumeroConsegne}\n";
    }

    public override void EseguiCompito()
    {
        Console.WriteLine($"Coordinamento di {numeroConsegne} consegne");
    }

    public override void EseguiCompito(string nome)
    {
        Console.WriteLine($"L'operatore logistico {Nome} sta coordinando {numeroConsegne} consegne");
    }
}
