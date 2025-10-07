using EsempioOperazioni;

Operazioni operazioni =  new();

int numero_1;
while (true)
{
    Console.WriteLine("Inserisci il primo numero di due");
    string? input = Console.ReadLine();

    if (int.TryParse(input, out numero_1))
        break;
    else
        Console.WriteLine("Input non valido. Inserisci un numero intero");
}

int numero_2;
while (true)
{
    Console.WriteLine("Inserisci il secondo numero di due");
    string? input = Console.ReadLine();

    if (int.TryParse(input, out numero_2))
        break;
    else
        Console.WriteLine("Input non valido. Inserisci un numero intero");
}

operazioni.StampaRisultato("Somma", operazioni.Somma(numero_1, numero_2));

operazioni.StampaRisultato("Moltiplicazione", operazioni.Moltiplica(numero_1, numero_2));