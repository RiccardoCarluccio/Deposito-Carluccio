using EsercizioDispositiviElettronici.ClassiAstratte;

namespace EsercizioDispositiviElettronici.Estensioni;

public static class SceltaDispositivi
{
    public static void MostraInfoDispositivo(
        List<DispositivoElettronico> dispositivi,
        string modello)
    {
        var dispositivo = dispositivi.FirstOrDefault(d => d.Modello == modello);
        
        if (dispositivo is null)
        {
            Console.WriteLine("Dispositivo non trovato");
        }
        else
        {
            dispositivo.Accendi();
            dispositivo.Spegni();
            dispositivo.MostraInfo();
            Console.WriteLine("");
        }
    }
}
