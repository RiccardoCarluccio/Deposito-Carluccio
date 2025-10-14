using EsercizioPagamento.Interfacce;

namespace EsercizioPagamento.Classi;

public class PagamentoCarta : IPagamento
{
    private string _circuito;

    public string Circuito
    {
        get { return _circuito; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                _circuito = value;
        }
    }

    public PagamentoCarta(string circuito)
    {
        Circuito = circuito;
    }

    public void EseguiPagamento(decimal importo)
    {
        Console.WriteLine($"Pagamento di {importo} euro con carta (Circuito: {Circuito})");
    }

    public void MostraMetodo()
    {
        Console.WriteLine("Metodo: Carta di credito");
    }
}
