namespace EsercizioOfficina.Veicoli;

public class Moto : Veicolo
{
    public Moto(string targa)
        : base(targa)
    {
    }

    public override void Ripara()
    {
        Console.WriteLine("Controllo olio, freni e gomme della moto");
    }
}
