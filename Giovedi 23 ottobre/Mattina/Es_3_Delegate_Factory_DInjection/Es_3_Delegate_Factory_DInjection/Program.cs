using Es_3_Delegate_Factory_DInjection.DependencyInjection;
using Es_3_Delegate_Factory_DInjection.Factory;

int input;
decimal importo;
IPagamento? pagamento = null;

var random = new Random();
bool randomBool = random.Next(2) == 1;      //per decidere se applicare lo sconto

void Log(string id, decimal importoFinale)
{
    Console.WriteLine($"[CONSOLE] Pagamento dell'ordine con id: '{id}' completato. Prezzo finale: {importoFinale} euro");
}

void InvioEmailSimulata(string id, decimal importoFinale)
{
    Console.WriteLine($"[EMAIL] Pagamento dell'ordine con id: '{id}' completato. Prezzo finale: {importoFinale} euro");
}

while (true)
{
    Console.WriteLine("Scegli come effettuare il pagamento:\n" +
        "1. Carta\n" +
        "2. PayPal\n" +
        "3. Bonifico\n" +
        "0. Esci");
    input = int.Parse(Console.ReadLine()!);

    switch (input)
    {
        case 1:
        case 2:
        case 3:
            pagamento = Pagamento_Factory.CreaPagamento(input - 1);
            break;

        case 0:
            Console.WriteLine("Uscita dal programma");
            return;

        default:
            Console.WriteLine("Input non valido");
            continue;
    }
    break;
}

Console.WriteLine("");

if (pagamento != null)
{   
    Console.WriteLine("Inserisci l'importo da pagare");

    importo = decimal.Parse(Console.ReadLine()!);
    if (importo <= 0)
    {
        Console.WriteLine("Importo non valido");
        return;
    }

    ILogger logger = new Logger();
    IDiscountPolicy sconto = randomBool ? new Scontato() : new NoSconto();

    var service = new PaymentService(pagamento, logger, sconto);

    service.OnPagamentoCompletato += Log;
    service.OnPagamentoCompletato += InvioEmailSimulata;

    service.Paga("test_id", importo);
}