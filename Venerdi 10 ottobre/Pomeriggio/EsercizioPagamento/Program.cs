using EsercizioPagamento.Classi;
using EsercizioPagamento.Estensioni;
using EsercizioPagamento.Interfacce;

List<IPagamento> pagamenti = new()
{
    new PagamentoCarta("Mastercard"),
    new PagamentoContanti(),
    new PagamentoPayPal("email@gmail.com")
};

int input;
do
{
    Console.WriteLine("Scegli un'operazione\n" +
        "1. Visualizza le operazioni\n" +
        "2. Effettua un'operazione\n" +
        "0. Esci dal programma\n");

    input = int.Parse(Console.ReadLine()!);

    switch (input)
    {
        case 1:
            foreach (var operazione in pagamenti)
            {
                operazione.MostraMetodo();
            }
            Console.WriteLine("");
            break;

        case 2:
            Console.WriteLine("Scegli l'operazione\n" +
                "1. Pagamento con Carta\n" +
                "2. Pagamento con Contanti\n" +
                "3. Pagamento con PayPal\n");
            int sceltaPagamento = int.Parse(Console.ReadLine()!);
            if (sceltaPagamento >= 1 && sceltaPagamento <= pagamenti.Count)
            {
                IPagamento pagamentoScelto = pagamenti[sceltaPagamento - 1];
                Console.Write("Inserisci l'importo: ");
                decimal importo = decimal.Parse(Console.ReadLine()!);

                Operazioni.EseguiOperazione(pagamentoScelto, importo);
            }
            else
            {
                Console.WriteLine("Scelta non valida.");
            }
            break;

        case 0:
            Console.WriteLine("Uscita dal programma");
            break;

        default:
            Console.WriteLine("Input non valido");
            break;
    }
}
while (input != 0);