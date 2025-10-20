using Es_Dizionari_E_Pattern.Singleton;

var istanza = BankContext.Instance;

int input;
do
{
    Console.WriteLine("Seleziona l'operazione:\n" +
        "1. Visualizza i clienti\n" +
        "2. Aggiungi un cliente\n" +
        "3. Rimuovi un cliente\n" +
        "4. Aggiungi un conto\n" +

        "0. Esci dal terminale");

    input = int.Parse(Console.ReadLine()!);

    switch (input)
    {
        case 1:
            istanza.VisualizzaClienti();
            break;

        case 0:
            Console.WriteLine("Uscita dal terminale");
            break;

        default:
            Console.WriteLine("Scelta non valida");
            break;
    }
}
while (input != 0);