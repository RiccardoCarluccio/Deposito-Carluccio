using Es_DuePattern.Factories;
using Es_DuePattern.Interfacce;
using Es_DuePattern.Singleton;

string sceltaVeicolo;
do
{
    Console.WriteLine("Seleziona il veicolo da creare:\n" +
    "Auto, Moto, Camion\n" +
    "'Fine' per chiudere il programma");

    sceltaVeicolo = Console.ReadLine()!;

    if (sceltaVeicolo.ToLower() != "fine")
    {
        IVeicolo veicolo = VeicoloFactory.CreaVeicolo(sceltaVeicolo);

        RegistroVeicoli.Instance.Registra(veicolo);

        if (veicolo != null)
        {
            veicolo.Avvia();
            veicolo.MostraTipo();
        }
        else
        {
            Console.WriteLine("Veicolo non valido");
        }

        Console.WriteLine("\nRegistroVeicoli.Instance.StampaTutti():");
        RegistroVeicoli.Instance.StampaTutti();
        Console.WriteLine("");
    }
    else
        Console.WriteLine("Chiusura del programma");
}
while (sceltaVeicolo.ToLower() != "fine");

