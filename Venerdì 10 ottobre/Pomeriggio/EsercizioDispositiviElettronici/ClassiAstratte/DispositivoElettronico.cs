namespace EsercizioDispositiviElettronici.ClassiAstratte;

public abstract class DispositivoElettronico
{
    private string _modello;

    public string Modello
    {
        get { return _modello; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                _modello = value;
        }
    }

    public abstract void Accendi();

    public abstract void Spegni();

    public virtual void MostraInfo()
    {
        Console.WriteLine($"Modello: {Modello}");
    }
}
