//non completato per mancanza di tempo per via di colloqui

int crediti = 10;
int registrazione = 0;

do
{
    Console.WriteLine("Inserisci il tuo nome per registrarti")

    Console.WriteLine("Inserisci i dati per customizzare la tua macchina\n" +
        "O scrivi 'end' per terminare il programma\n" +
    "Inizia inserendo il nome del motore");
    string? motore = Console.ReadLine();

    Console.WriteLine("Inserisci la velocità massima");
    float velocitaMac = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Inserisci le sospensioni massime");
    int sospensioniMax = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Inserisci il numero di modifiche");
    int nrModifiche = int.Parse(Console.ReadLine()!);

    registrazione++;
}
while (registrazione <= 3);

do
{

}
while (false); //TODO