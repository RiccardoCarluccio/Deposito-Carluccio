using EsercizioCorsoFormativo.ClassiAstratte;

namespace EsercizioCorsoFormativo.Classi;

public class CorsoInPresenza : Corso
{
    private string _aula;
    private int _numeroPosti;

    public string Aula
    {
        get { return _aula; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                _aula = value;
        }
    }

    public int NumeroPosti
    {
        get { return _numeroPosti; }
        set
        {
            if (value > 0)
                _numeroPosti = value;
        }
    }

    public CorsoInPresenza(string titolo, int durataOre, string aula, int numeroPosti)
        : base(titolo, durataOre)
    {
        Aula = aula;
        NumeroPosti = numeroPosti;
    }

    public override void ErogaCorso()
    {
        throw new NotImplementedException();
    }

    public override void StampaDettagli()
    {
        Console.WriteLine($"Il corso da {Titolo} di durata di {DurataOre} ore" +
            $"si svolge in aula {Aula} con {NumeroPosti} posti a sedere");
    }

    public override void StampaDettagli(Corso corso)
    {
        Console.WriteLine($"Il corso da {corso.Titolo} di durata di {corso.DurataOre} ore" +
            $"si svolge in aula {Aula} con {NumeroPosti} posti a sedere");
    }    
}
