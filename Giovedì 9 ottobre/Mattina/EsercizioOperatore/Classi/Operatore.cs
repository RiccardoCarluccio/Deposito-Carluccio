namespace EsercizioOperatore.Classi;

public class Operatore
{
    private string nome;
    private string turno;    

    public string Nome
    {
        get { return nome; }
        set
        {
            if (value is not null)
                nome = value;
        }
    }

    public string Turno
    {
        get { return turno; }
        set
        {
            if (value == "Giorno" || value == "Notte")
                turno = value;
        }
    }

    public Operatore(string nome, string turno)
    {
        Nome = nome;
        Turno = turno;
    }

    public override string ToString()
    {
        return
            $"Nome: {Nome}\n" +
            $"Turno: {Turno}\n";
    }

    public virtual void EseguiCompito()
    {
        Console.WriteLine("Operatore generico in servizio");
    }

    public virtual void EseguiCompito(string nome)
    {
        Console.WriteLine($"L'operatore generico {Nome} è in servizio");
    }
}
