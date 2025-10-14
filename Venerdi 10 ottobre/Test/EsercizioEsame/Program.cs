using EsercizioEsame.Classi;
using EsercizioEsame.Dati;
using EsercizioEsame.Estensioni;

List<Animale> animali = new(InMemory.ListaAnimali.animali);

int input;
do
{
    Console.WriteLine("Seleziona un'operazione:\n" +
        "1. Visualizza tutti gli animali\n" +
        "2. Aggiungi un gatto\n" +
        "3. Aggiungi un pinguino\n" +
        "4. Elimina un animale dal database\n" +
        "5. Esci dal programma");

    input = int.Parse(Console.ReadLine()!);

    switch (input)
    {
        case 1:
            foreach (var animale in animali)
            {
                Console.WriteLine(animale);
                //manca l'override del ToString() nelle classi richiamate per visualizzare le informazioni in modo corretto
            }
            break;

        case 2:
            animali.Add(AggiungiAnimali.AggiungiPinguino());    //polimorfismo
            break;

        case 3:
            break;

        case 4:
            break;

        case 5:
            Console.WriteLine("Uscita dal programma");
            break;

        default:
            Console.WriteLine("Input non valido");
            break;
    }
}
while (input != 5);