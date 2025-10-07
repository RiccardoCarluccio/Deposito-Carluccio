using EsercizioCorsi.Corsi;

List<CorsoBase> corsi = new();
List<string> studenti = new();

int input;
do
{
    Console.WriteLine("Seleziona l'operazione:\n" +
        "1. Aggiungi un corso di Musica\n" +
        "2. Aggiungi un corso di Pittura\n" +
        "3. Aggiungi un corso di Danza\n" +
        "4. Aggiungi uno studente\n" +
        "5. Visualizza tutti i corsi\n" +
        "6. Cerca corsi per nome docente\n" +
        "7. Esegui metodo speciale di un corso\n" +
        "0. Esci");

    input = int.Parse(Console.ReadLine()!);

    switch (input)
    {
        case 1:

            CorsoMusica corsoMusica = new(); //TODO
            CorsoMusica.AggiungiCorso();
            corsi.Add(corsoMusica);
            break;

        default:
            Console.WriteLine("Scelta non valida");
            break;
    }
}
while (input != 0);