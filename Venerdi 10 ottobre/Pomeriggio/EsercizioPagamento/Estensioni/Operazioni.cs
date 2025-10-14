using EsercizioPagamento.Interfacce;

namespace EsercizioPagamento.Estensioni;

public static class Operazioni
{
    public static void EseguiOperazione(IPagamento pagamento, decimal importo)
    {
        pagamento.MostraMetodo();
        pagamento.EseguiPagamento(importo);
        Console.WriteLine("");
    }
}
