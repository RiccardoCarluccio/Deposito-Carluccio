using EsercizioCorsoFormativo.ClassiAstratte;

namespace EsercizioCorsoFormativo.Classi;

public class CorsoOnline : Corso
{
    private string _piattaforma;
    private string _linkAccesso;

    public string Piattaforma
    {
        get { return _piattaforma; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                _piattaforma = value;
        }
    }

    public string LinkAccesso
    {
        get { return _linkAccesso; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                _linkAccesso = value;
        }
    }

    public CorsoOnline(string titolo, int durataOre, string piattaforma, string linkAccesso)
        : base(titolo, durataOre)
    {
        Piattaforma = piattaforma;
        LinkAccesso = linkAccesso;
    }

    public override void ErogaCorso()
    {
        throw new NotImplementedException();        //TODO
    }
    
    public override void StampaDettagli()
    {
        throw new NotImplementedException();        //TODO
    }

    public override void StampaDettagli(Corso corso)
    {
        throw new NotImplementedException();        //TODO
    }
}
