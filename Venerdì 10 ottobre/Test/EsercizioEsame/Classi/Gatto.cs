namespace EsercizioEsame.Classi;

public class Gatto : Animale
{
    private string colore;

    public string Colore
    {
        get { return colore; }
        set
        {
            if (string.IsNullOrEmpty(value))
                colore = value;
        }
    }

    public Gatto(string nome, int anni, string colore)
        : base(nome, anni)
    {
        Colore = colore;
    }

    public override void Verso()        //override
    {
        Console.WriteLine($"{Nome} di colore {Colore} miagola");
    }

    public override void Verso(int anni)
    {
        Console.WriteLine($"{Nome} di colore {Colore} miagola da {Anni} anni");
    }
}
