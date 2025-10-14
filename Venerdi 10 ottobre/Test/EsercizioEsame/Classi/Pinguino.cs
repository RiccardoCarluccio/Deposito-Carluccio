using System.Drawing;

namespace EsercizioEsame.Classi;

public class Pinguino : Animale
{
    private int velocitaMassima;

    public int VelocitaMassima
    {
        get { return velocitaMassima; }
        set
        {
            if (value >= 0 && value <= 20)
                velocitaMassima = value;
        }
    }

    public Pinguino(string nome, int anni, int velocitaMassima)
        : base(nome, anni)
    {
        VelocitaMassima = velocitaMassima;
    }

    public override void Verso()
    {
        Console.WriteLine($"{Nome} pingua");
    }

    public override void Verso(int velocitaMassima)
    {
        Console.WriteLine($"{Nome} corre a {velocitaMassima} km/h");
    }
}
