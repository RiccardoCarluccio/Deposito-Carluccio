namespace EsercizioEsame.Classi;

public class Animale
{
    private string nome;
    private int anni;

    public string Nome         //incapsulamento
    {
        get { return nome; }
        set
        {   
            if (string.IsNullOrEmpty(value))
                nome = value;
        }
    }

    public int Anni
    {
        get { return anni; }
        set
        {
            if (value >= 0)
                anni = value;
        }
    }

    public Animale(string nome, int anni)
    {
        Nome = nome;
        Anni = anni;
    }

    public virtual void Verso()
    {
        Console.WriteLine($"{Nome} fa il suo verso");
    }

    public virtual void Verso(int anni)     //overload
    {
        Console.WriteLine($"{Nome} fa il suo verso da {anni} anni");
    }
}
