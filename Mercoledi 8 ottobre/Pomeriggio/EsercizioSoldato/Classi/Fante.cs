namespace EsercizioSoldato.Classi;

public class Fante : Soldato
{
    private string arma;

    public string Arma
    {
        get { return arma; }
        set { arma = value; }
    }

    public Fante(string nazione, string nome, string grado, int anniServizio, string arma)
        : base(nazione, nome, grado, anniServizio)
    {
        Arma = arma;
    }

    public override string ToString()
    {
        return
            "\n" +
            $"Nazione: {Nazione}\n" +
            $"Nome soldato: {Nome}\n" +
            $"Grado: {Grado}\n" +
            $"Anni di servizio: {AnniServizio}\n" +
            $"Arma: {Arma}\n";
    }
}