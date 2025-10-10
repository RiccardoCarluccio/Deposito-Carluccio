using EsercizioDispositiviElettronici.ClassiAstratte;

namespace EsercizioDispositiviElettronici.Classi;

public class Computer : DispositivoElettronico
{
    public Computer(string modello)
        : base()
    {
        Modello = modello;
    }

    public override void Accendi()
    {
        Console.WriteLine("Il computer si avvia...");
    }

    public override void Spegni()
    {
        Console.WriteLine("Il computer si spegne.");
    }
}
