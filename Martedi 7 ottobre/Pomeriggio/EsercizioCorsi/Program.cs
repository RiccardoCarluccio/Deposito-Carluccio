using EsercizioCorsi.Corsi;
using EsercizioCorsi.Estensioni;

List<string> studentiMusicaMandolino =
[
    "Elena", "Valerio", "Valentina"
];

List<string> studentiPitturaImpressionismo =
[
    "Simone", "Lorenzo", "Pietro"
];

List<string> studentiDanzaClassica =
[
    "Andrea", "Marco", "Salvatore"
];

int indice = 3;

List<CorsoBase> corsi = new List<CorsoBase>();

CorsoMusica corsoMusicaMandolino = new CorsoMusica(
    1, "Corso di Mandolino", 900, "Marco Bianchi", studentiMusicaMandolino, "Mandolino");

CorsoPittura corsoPitturaImpressionismo = new CorsoPittura(
    2, "Corso di Impressionismo", 900, "Paolo Rossi", studentiPitturaImpressionismo, "Impressionismo");

CorsoDanza corsoDanzaClassica = new CorsoDanza(
    3, "Corso di Danza Classica", 900, "Giovanni Verdi", studentiDanzaClassica, "Classico");

corsi.Add(corsoMusicaMandolino);
corsi.Add(corsoPitturaImpressionismo);
corsi.Add(corsoDanzaClassica);

int input;
int indiceCorso;
CorsoBase? corsoSelezionato;
do
{                                                           //aggiungere i check con i TryParse()
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
            corsi.Add(Estensioni.AggiungiCorsoMusica(ref indice));
            break;

        case 2:
            corsi.Add(Estensioni.AggiungiCorsoPittura(ref indice));
            break;

        case 3:
            corsi.Add(Estensioni.AggiungiCorsoDanza(ref indice));
            break;

        case 4:
            Console.WriteLine("Scegli, tramite indice, il corso a cui aggiungere lo studente");
            indiceCorso = int.Parse(Console.ReadLine()!);
            corsoSelezionato = corsi.FirstOrDefault(c => c.Indice == indiceCorso);
            if (corsoSelezionato is not null)
            {
                Console.WriteLine("Aggiungi il nome dello studente");
                string nomeStudente = Console.ReadLine()!;
                Estensioni.AggiungiStudente(corsoSelezionato, nomeStudente);
            }
            else
                Console.WriteLine("Indice corso non trovato");
            break;

        case 5:
            foreach (var corso in corsi)
            {
                Console.WriteLine(corso.ToString());
                Console.WriteLine("");
            }
            break;

        case 6:
            Console.WriteLine("Scrivi il nome del docente");
            string nomeDocente = Console.ReadLine()!.ToLower();
            var corsoPerDocente = corsi.FirstOrDefault(d => d.Docente.ToLower() == nomeDocente);
            if (corsoPerDocente is not null)
                Console.WriteLine($"Il docente {corsoPerDocente.Docente} insegna nel {corsoPerDocente.NomeCorso}\n");
            else
                Console.WriteLine("Indice corso non trovato");
            break;

        case 7:
            Console.WriteLine("Scegli, tramite indice, il corso di cui avere la descrizione");
            indiceCorso = int.Parse(Console.ReadLine()!);
            corsoSelezionato = corsi.FirstOrDefault(c => c.Indice == indiceCorso);
            if (corsoSelezionato is not null)
            {
                corsoSelezionato.MetodoSpeciale();
            }
            else
                Console.WriteLine("Indice corso non trovato");
            break;

        case 0:
            Console.WriteLine("Chiusura applicazione");
            break;

        default:
            Console.WriteLine("Scelta non valida");
            break;
    }
}
while (input != 0);