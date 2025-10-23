using Es_3_Delegate_Factory_DInjection.Factory;

namespace Es_3_Delegate_Factory_DInjection.DependencyInjection;

public delegate void PagamentoCompletatoHandler(string id, decimal totale);

public class PaymentService
{
    private readonly IPagamento _pagamento;
    private readonly ILogger _logger;
    private readonly IDiscountPolicy _discountPolicy;

    public event PagamentoCompletatoHandler? OnPagamentoCompletato;

    public PaymentService(
        IPagamento pagamento,
        ILogger logger,
        IDiscountPolicy discountPolicy)
    {
        _pagamento = pagamento;
        _logger = logger;
        _discountPolicy = discountPolicy;
    }

    public void Paga(string id, decimal importo)
    {
        decimal importoFinale = _discountPolicy.Sconta(importo);

        if (importoFinale == importo)
            _logger.Log($"Nessuno sconto applicato. Prezzo finale: {importoFinale} euro");
        else
            _logger.Log($"Sconto del 10% applicato. Prezzo finale: {importoFinale} euro");

        _pagamento.Paga(importoFinale);

        OnPagamentoCompletato?.Invoke(id, importoFinale);
    }
}
