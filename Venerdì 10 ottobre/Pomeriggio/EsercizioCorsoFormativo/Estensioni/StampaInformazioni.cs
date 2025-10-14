using EsercizioCorsoFormativo.ClassiAstratte;

namespace EsercizioCorsoFormativo.Estensioni;

public static class StampaInformazioni
{
    public static void Stampa(Corso corso)
    {
        corso.StampaDettagli(corso);
        Console.WriteLine("");
    }
}
