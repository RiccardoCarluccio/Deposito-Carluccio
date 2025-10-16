namespace EsercizioOfficina.Veicoli;

public class Veicolo
{
    private string targa;

    public string Targa
    {
        get {  return targa; }
        set
        { 
            if (value is not null)
                targa = value;
        }
    }

    public Veicolo(string targa)
    {
        Targa = targa;
    }

    public virtual void Ripara()
    {
        Console.WriteLine("Il veicolo viene controllato");
    }
}
