namespace EsercizioSoldato.Classi;

public class Artigliere : Soldato
{
    private int calibro;

    public int Calibro
    {
        get { return calibro; }
        set { calibro = value; }
    }

    public Artigliere(string nome, string grado, int anniServizio, int calibro)
        : base(nome, grado, anniServizio)
    {
        Calibro = calibro;
    }

    public override void Descrizione()
    {
        base.Descrizione();
        Console.WriteLine($"Calibro: {Calibro}");
    }
}
