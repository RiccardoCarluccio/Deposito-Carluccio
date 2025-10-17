namespace Es_Dictionary_3Esercizi;

public static class Frase
{
    public static Dictionary<string, int> contatore = [];
    public static string declinazione = "";

    public static string[] AggiungiFrase()
    {
        Console.WriteLine("Scrivi una frase");
        string frase = Console.ReadLine()!;

        string[] parole = frase.Split(' ');
        return parole;
    }

    public static void ContaRicorrenze(string[] parole)
    {
        foreach (string parola in parole)
        {
            if (contatore.ContainsKey(parola))
                contatore[parola]++;
            else
                contatore.Add(parola, 1);
        }
    }

    public static void MostraRicorrenze()
    {
        foreach (var kvp in contatore)
        {
            if (kvp.Value == 1)
                declinazione = "volta";
            else
                declinazione = "volte";

            Console.WriteLine($"La parola {kvp.Key} è presente {kvp.Value} {declinazione} nella frase");

        }
    }
}
