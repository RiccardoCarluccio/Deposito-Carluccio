namespace Es_3_Delegate_Factory_DInjection.Factory;

public class Pagamento
{
    public class PagamentoCarta : IPagamento
    {
        public void Paga(decimal importo)
        {
            Console.WriteLine($"Pagamento di {importo} euro tramite carta");
        }
    }

    public class PagamentoPayPal : IPagamento
    {
        public void Paga(decimal importo)
        {
            Console.WriteLine($"Pagamento di {importo} euro tramite PayPal");
        }
    }

    public class PagamentoBonifico : IPagamento
    {
        public void Paga(decimal importo)
        {
            Console.WriteLine($"Pagamento di {importo} euro tramite bonifico");
        }
    }
}
