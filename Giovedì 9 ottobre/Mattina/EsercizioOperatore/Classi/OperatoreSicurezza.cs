namespace EsercizioOperatore.Classi;

public class OperatoreSicurezza : Operatore
{
    private string areaSorvegliata;

    public string AreaSorvegliata
    {
        get { return areaSorvegliata; }
        set
        {
            if (value is not null)
                areaSorvegliata = value;
        }
    }

    public OperatoreSicurezza(string nome, string turno, string areaSorvegliata)
        : base(nome, turno)
    {
        AreaSorvegliata = areaSorvegliata;
    }

    public override string ToString()
    {
        return
            $"Nome: {Nome}\n" +
            $"Turno: {Turno}\n" +
            $"Area sorvegliata: {AreaSorvegliata}\n";
    }

    public override void EseguiCompito()
    {
        Console.WriteLine($"Sorveglianza dell'area {AreaSorvegliata}");
    }

    public override void EseguiCompito(string nome)
    {
        Console.WriteLine($"L'operatore di sicurezza {Nome} sta sorvegliando l'area {AreaSorvegliata}");
    }
}
