public class Veicolo
{
    public string Marca;
    public string Modello;

    public virtual void AggiungiVeicolo()
    {
        Console.Write("\nInserisci la marca: ");
        Marca = Console.ReadLine()!;
        Console.Write("\nInserisci il modello: ");
        Modello = Console.ReadLine()!;
    }
}

public class Auto : Veicolo
{
    public int NumeroPorte;

    public override string ToString()
    {
        return $"Marca: {Marca}, Modello: {Modello}, Numero Porte: {NumeroPorte}";
    }

    public override void AggiungiVeicolo()
    {
        base.AggiungiVeicolo();
        Console.Write("\nInserisci il numero di porte: ");
        NumeroPorte = int.Parse(Console.ReadLine()!);
    }
}

public class Moto : Veicolo
{
    public string TipoManubrio;

    public override string ToString()
    {
        return $"Marca: {Marca}, Modello: {Modello}, Tipo Manubrio: {TipoManubrio}";
    }

    public override void AggiungiVeicolo()
    {
        base.AggiungiVeicolo();
        Console.Write("\nInserisci il tipo di manubrio: ");
        TipoManubrio = Console.ReadLine()!;
    }
}