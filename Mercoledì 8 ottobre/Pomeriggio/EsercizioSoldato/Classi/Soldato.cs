namespace EsercizioSoldato.Classi;

public class Soldato
{
    private string nome;
    private string grado;
    private int anniServizio;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Grado
    {
        get { return grado; }
        set { grado = value; }
    }

    public int AnniServizio
    {
        get { return anniServizio; }
        set
        {
            if (value >= 0)
                anniServizio = value;
        }
    }

    public Soldato(string nome, string grado, int anniServizio)
    {
        Nome = nome;
        Grado = grado;
        AnniServizio = anniServizio;
    }

    public virtual void Descrizione()
    {
        Console.WriteLine(
            $"Nome soldato: {Nome}\n" +
            $"Grado: {Grado}\n" +
            $"Anni di servizio: {AnniServizio}\n");
    }

    public override string ToString()
    {
        return
            $"Nome soldato: {Nome}\n" +
            $"Grado: {Grado}\n" +
            $"Anni di servizio: {AnniServizio}\n";
    }
}
