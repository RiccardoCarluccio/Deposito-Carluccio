using EsercizioPagamento.Interfacce;

namespace EsercizioPagamento.Classi;

public class PagamentoContanti : IPagamento
{
    public void EseguiPagamento(decimal importo)
    {
        Console.WriteLine($"Pagamento di {importo} euro in contanti");
    }

    public void MostraMetodo()
    {
        Console.WriteLine("Metodo: Contanti");
    }
}
