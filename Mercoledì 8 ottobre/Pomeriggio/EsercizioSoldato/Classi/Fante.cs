namespace EsercizioSoldato.Classi;

public class Fante : Soldato
{
    private string arma;

    public string Arma
    {
        get { return arma; }
        set { arma = value; }
    }

    public Fante(string nome, string grado, int anniServizio, string arma)
        : base(nome, grado, anniServizio)
    {
        Arma = arma;
    }

    public override void Descrizione()
    {
        base.Descrizione();
        Console.WriteLine($"Arma: {Arma}\n");
    }

    public override string ToString()
    {
        return
            "\n" +
            $"Nome soldato: {Nome}\n" +
            $"Grado: {Grado}\n" +
            $"Anni di servizio: {AnniServizio}\n" +
            $"Arma: {Arma}\n";
    }
}
