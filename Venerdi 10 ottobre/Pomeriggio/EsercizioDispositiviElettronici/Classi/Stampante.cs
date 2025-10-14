using EsercizioDispositiviElettronici.ClassiAstratte;

namespace EsercizioDispositiviElettronici.Classi;

public class Stampante : DispositivoElettronico
{
    public Stampante(string modello)
        : base()
    {
        Modello = modello;
    }

    public override void Accendi()
    {
        Console.WriteLine("La stampante si accende");
    }

    public override void Spegni()
    {
        Console.WriteLine("La stampante va in standby");
    }
}
