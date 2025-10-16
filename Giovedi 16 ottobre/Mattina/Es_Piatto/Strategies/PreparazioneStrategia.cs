using Es_Piatto.Factories;

namespace Es_Piatto.Strategies;

public interface IPreparazioneStrategia
{
    string Prepara(string descrizione);
}

public class Fritto : IPreparazioneStrategia
{
    public string Prepara(string descrizione)
    {
        return "fritto";
    }
}

public class AlForno : IPreparazioneStrategia
{
    public string Prepara(string descrizione)
    {
        return "al forno";
    }
}

public class AllaGriglia : IPreparazioneStrategia
{
    public string Prepara(string descrizione)
    {
        return "alla griglia";
    }
}

public class Chef
{
    private IPreparazioneStrategia _strategia;

    public void ImpostaStrategia(IPreparazioneStrategia strategia)
    {
        _strategia = strategia;
    }

    public void PreparaPiatto(IPiatto piatto)
    {
        if (_strategia == null)
        {
            Console.WriteLine("Nessuna strategia impostata");
            return;
        }
        string result = _strategia.Prepara(piatto.ToString());
        //Console.WriteLine("...") ?
    }
}