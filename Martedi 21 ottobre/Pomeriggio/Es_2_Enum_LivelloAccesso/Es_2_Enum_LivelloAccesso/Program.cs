public enum LivelloAccesso
{
    Ospite,
    Utente,
    Amministratore
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Scegli il tipo di utente per verificarne i privilegi\n" +
            "1. Ospite\n" +
            "2. Utente\n" +
            "3. Amministratore");
        int input = int.Parse(Console.ReadLine()!);

        switch (input)
        {
            case ((int)LivelloAccesso.Ospite + 1):
                Console.WriteLine("L'ospite può solo visionare la home page");
                break;

            case ((int)LivelloAccesso.Utente + 1):
                Console.WriteLine("L'utente può fare l'accesso all'area riservata");
                break;

            case ((int)LivelloAccesso.Amministratore + 1):
                Console.WriteLine("L'amministratore può gestire le configurazioni degli utenti");
                break;

            default:
                Console.WriteLine("Input non valido");
                break;
        }
    }
}