using EsercizioPagamento.Interfacce;

namespace EsercizioPagamento.Classi;

public class PagamentoPayPal : IPagamento
{
    private string _emailUtente;

    public string EmailUtente
    {
        get { return _emailUtente; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                _emailUtente = value;
        }
    }

    public PagamentoPayPal(string emailUtente)
    {
        EmailUtente = emailUtente;
    }

    public void EseguiPagamento(decimal importo)
    {
        Console.WriteLine($"Pagamento di {importo} euro tramite PayPal da: {EmailUtente}");
    }

    public void MostraMetodo()
    {
        Console.WriteLine("Metodo: PayPal");
    }
}
