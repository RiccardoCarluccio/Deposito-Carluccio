List<Veicolo> veicoli = new();

int input;
do
{
    Console.WriteLine("Seleziona l'operazione da eseguire:\n" +
        "1. Inserire nuovo veicolo\n" +
        "2. Visualizzare tutti i veicoli presenti\n" +
        "3. Uscire dal programma");

    input = int.Parse(Console.ReadLine()!);

    switch (input)
    {
        case 1:
            Console.WriteLine("Che tipo di veicolo vuoi aggiungere?\n" +
                "1. Auto\n" +
                "2. Moto\n" +
                "3. Torna indietro");
            int tipo = int.Parse(Console.ReadLine()!);

            if (tipo == 3)
                break;

            Veicolo nuovoVeicolo = new();
            switch (tipo)
            {
                case 1:
                    nuovoVeicolo = new Auto();
                    break;
                case 2:
                    nuovoVeicolo = new Moto();
                    break;
                default:
                    Console.WriteLine("Scelta non valida\n");
                    break;
            }
            nuovoVeicolo.AggiungiVeicolo();
            veicoli.Add(nuovoVeicolo);
            break;

        case 2:
            if (veicoli.Count == 0)
                Console.WriteLine("Non ci sono veicoli presenti\n");
            else
            {
                foreach (var veicolo in veicoli)
                    Console.WriteLine(veicolo);
                Console.WriteLine("\n\n");
            }
            break;

        default:
            break;
    }
}
while (input != 3);