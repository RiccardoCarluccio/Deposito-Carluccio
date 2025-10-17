using Es_Dictionary.Metodi;
using Es_Dictionary.Singleton;

var db = DatabaseUtenti.Instance;

int input;
do
{
    Console.WriteLine("Scegli operazione:\n" +
        "1. Visualizza utenti\n" +
        "2. Aggiungi utente\n" +
        "3. Rimuovi utente\n" +
        "0. Esci dal programma");
    input = int.Parse(Console.ReadLine()!);

    switch (input)
    {
        case 1:
            db.VisualizzaUtenti();
            break;

        case 2:
            var utente = CreazioneUtente.CreaUtente();
            db.AggiungiUtente(utente);
            break;

        case 3:
            Console.WriteLine("Inserisci l'id dell'utente da rimuovere");
            int id = int.Parse(Console.ReadLine()!);
            db.RimuoviUtente(id);
            break;

        case 0:
            break;
    }

}
while (input != 0);