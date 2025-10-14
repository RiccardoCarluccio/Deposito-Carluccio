using EsercizioOperatore.Classi;
using EsercizioOperatore.Dati;
using EsercizioOperatore.Estensioni;

List<Operatore> operatori = new List<Operatore>(ListaOperatori.operatori);

int input;
do
{
    Console.WriteLine("Scegli un'operazione:\n" +
        "1. Aggiungi un operatore d'emergenza\n" +
        "2. Aggiungi un operatore di sicurezza\n" +
        "3. Aggiungi un operatore di logistica\n" +
        "4. Mostra tutti gli operatori\n" +
        "5. Visualizza il compito dell'operatore selezionato\n" +
        "0. Uscire dal programma");

    input = int.Parse(Console.ReadLine()!);
    Console.WriteLine("");

    switch (input)
    {
        case 1:
            operatori.Add(AggiungiOperatore.AggiungiOperatoreEmergenza());
            break;

        case 2:
            operatori.Add(AggiungiOperatore.AggiungiOperatoreSicurezza());
            break;

        case 3:
            operatori.Add(AggiungiOperatore.AggiungiOperatoreLogistica());
            break;

        case 4:
            foreach (var operatore in operatori)
            {
                Console.WriteLine(operatore.ToString());
            }
            break;

        case 5:
            EseguiCompiti.MostraCompitoOperatore(operatori);
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