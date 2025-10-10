using EsercizioDispositiviElettronici.Classi;
using EsercizioDispositiviElettronici.ClassiAstratte;
using EsercizioDispositiviElettronici.Estensioni;

List<DispositivoElettronico> dispositivi = new()
{
    new Computer("Asus"),
    new Stampante("Hp")
};

int input;
do
{
    Console.WriteLine("Scegli l'operazione\n" +
        "1. Aggiungi un Computer\n" +
        "2. Aggiungi una Stampante\n" +
        "3. Visualizza tutti i dispositivi\n" +
        "4. Visualizza un solo dispositivo\n" +
        "5. Esci dal programma\n");

    input = int.Parse(Console.ReadLine()!);

    switch (input)
    {
        case 1:
            dispositivi.Add(AggiuntaDispositivi.AggiungiComputer());
            break;

        case 2:
            dispositivi.Add(AggiuntaDispositivi.AggiungiStampante());
            break;

        case 3:
            foreach (var dispositivo in dispositivi)
            {
                Console.WriteLine("");
                dispositivo.Accendi();
                dispositivo.Spegni();
                dispositivo.MostraInfo();
                Console.WriteLine("");
            }
            break;

        case 4:
            Console.WriteLine("Scegli il modello di cui mostrare le informazioni");
            string modello = Console.ReadLine()!;
            SceltaDispositivi.MostraInfoDispositivo(dispositivi, modello);
            break;

        case 5:
            Console.WriteLine("Uscita dal programma");
            break;

        default:
            Console.WriteLine("Scelta non valida");
            break;
    }
}
while (input != 5);