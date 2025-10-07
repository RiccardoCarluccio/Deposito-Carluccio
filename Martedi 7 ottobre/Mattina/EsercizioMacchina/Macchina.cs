namespace EsercizioMacchina;

public class Macchina
{
    public string Motore;
    public float VelocitaMac;
    public int SospensioniMax;
    public int NrModifiche;

    public Macchina(string motore,
        float velocitaMac,
        int sospensioniMax,
        int nrModifiche)
    {
        this.Motore = motore;
        this.VelocitaMac = velocitaMac;
        this.SospensioniMax = sospensioniMax;
        this.NrModifiche = nrModifiche;
    }
}
