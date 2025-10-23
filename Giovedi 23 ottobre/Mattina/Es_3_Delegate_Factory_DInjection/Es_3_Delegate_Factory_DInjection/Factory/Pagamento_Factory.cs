using static Es_3_Delegate_Factory_DInjection.Factory.Pagamento;

namespace Es_3_Delegate_Factory_DInjection.Factory;

public abstract class Pagamento_Factory
{
    public static IPagamento? CreaPagamento(int tipo)
    {
        switch (tipo)
        {
            case (int)TipoPagamento.Carta:
                return new PagamentoCarta();

            case (int)TipoPagamento.PayPal:
                return new PagamentoPayPal();

            case (int)TipoPagamento.Bonifico:
                return new PagamentoBonifico();

            default:
                Console.WriteLine("Scelta non valida");
                return null;
        }
    }
}