using EsercizioSoldato.Classi;
using EsercizioSoldato.Dati;
using EsercizioSoldato.Estensioni;

List<Soldato> soldati = new List<Soldato>(InMemory.ListaSoldati.soldati);

int input;
do
{
    Console.WriteLine("Seleziona l'operazione:\n" +
        "1. Aggiungi un Fante\n" +
        "2. Aggiungi un Artigliere\n" +
        "3. Visualizza tutti i soldati\n" +
        "0. Esci dal programma");

    input = int.Parse(Console.ReadLine()!);

    switch (input)
    {
        case 1:
            soldati.Add(AggiungiSoldati.AggiungiFante());
            break;

        case 2:
            soldati.Add(AggiungiSoldati.AggiungiArtigliere());
            break;

        case 3:
            foreach (var soldato in soldati)
            {
                Console.WriteLine(soldato.ToString());
                Console.WriteLine("");
            }
            break;

        case 0:
            Console.WriteLine("Chiusura del programma");
            break;

        default:
            Console.WriteLine("Scelta non valida\n");
            break;
    }
}
while (input != 0);