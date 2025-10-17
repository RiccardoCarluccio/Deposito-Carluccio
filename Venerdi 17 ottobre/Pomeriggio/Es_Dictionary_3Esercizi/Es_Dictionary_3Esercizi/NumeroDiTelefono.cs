namespace Es_Dictionary_3Esercizi;

public static class NumeroDiTelefono
{
    public static Dictionary<string, int> rubrica = [];

    public static void AggiungiNumeriDiTelefono()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Inserisci un nome");
            string nome = Console.ReadLine()!;

            Console.WriteLine("Inserisci il suo numero di telefono");
            int numero = int.Parse(Console.ReadLine()!);

            rubrica.Add(nome, numero);
        }
    }

    public static void StampaRubrica()
    {
        foreach (var kvp in rubrica)
            Console.WriteLine($"Il numero di telefono di {kvp.Key} è: {kvp.Value}");
    }
}
