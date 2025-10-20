using Es_Dizionari_E_Pattern.Entita;
using Es_Dizionari_E_Pattern.Singleton;
using static Es_Dizionari_E_Pattern.Observer.Observers;

var istanza = BankContext.Instance;

istanza.Registra(new EmailObserver());

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

        case 2:
            Console.WriteLine("\nInserisci i dati del nuovo cliente:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("Email: ");
            string email = Console.ReadLine()!;
            istanza.AggiungiCliente(new Cliente(nome, email));
            istanza.Notifica($"{nome} aggiunto correttamente al database\n");
            break;

        case 3:
            Console.WriteLine("\nInserisci l'id del cliente da rimuovere");
            int id = int.Parse(Console.ReadLine()!);
            istanza.RimuoviCliente(id);
            istanza.Notifica($"L'utente con id: '{id}' è stato rimosso");
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