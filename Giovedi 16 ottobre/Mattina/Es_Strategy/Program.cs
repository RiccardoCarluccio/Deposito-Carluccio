using Es_Strategy.Singleton;
using Es_Strategy.Strategies;

var calcolatrice = new Calcolatrice();

double num1;
double num2;

RegistroUtenti.Instance.Registra("Mario");  //aggiungere l'input dell'utente

Console.WriteLine("Scegli l'operazione:\n" +
    "1. Addizione\n" +
    "2. Sottrazione\n" +
    "3. Moltiplicazione\n" +
    "4. Divisione\n");
int input = int.Parse(Console.ReadLine()!);

switch (input)
{
    case 1:
        calcolatrice.ImpostaStrategia(new SommaStrategiaConcreta());
        break;

    case 2:
        calcolatrice.ImpostaStrategia(new SottrazioneStrategiaConcreta());
        break;

    case 3:
        calcolatrice.ImpostaStrategia(new MoltiplicazioneStrategiaConcreta());
        break;

    case 4:
        calcolatrice.ImpostaStrategia(new DivisioneStrategiaConcreta());
        break;

    default:
        Console.WriteLine("Input non valido");
        break;
}

Console.WriteLine("Inserisci 2 numeri\n" +
    "Primo numero:");
num1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Secondo numero:");
num2 = double.Parse(Console.ReadLine()!);

calcolatrice.EseguiOperazione(num1, num2);