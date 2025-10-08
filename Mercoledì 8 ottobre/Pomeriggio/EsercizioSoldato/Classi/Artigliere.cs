namespace EsercizioSoldato.Classi;

public class Artigliere : Soldato
{
    private int calibro;

    public int Calibro
    {
        get { return calibro; }
        set { calibro = value; }
    }

    public Artigliere(string nazione, string nome, string grado, int anniServizio, int calibro)
        : base(nazione, nome, grado, anniServizio)
    {
        Calibro = calibro;
    }

    public override string ToString()
    {
        return
            "\n" +
            $"Nazione: {Nazione}\n" +
            $"Nome soldato: {Nome}\n" +
            $"Grado: {Grado}\n" +
            $"Anni di servizio: {AnniServizio}\n" +
            $"Calibro: {Calibro}\n";
    }
}