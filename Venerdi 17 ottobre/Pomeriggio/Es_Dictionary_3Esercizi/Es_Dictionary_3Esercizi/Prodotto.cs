namespace Es_Dictionary_3Esercizi;

public static class Prodotto
{
    public static Dictionary<string, int> prodotti = [];

    public static void AggiungiProdotto()
    {
        Console.WriteLine("Aggiungi un prodotto");
        string prodotto = Console.ReadLine()!;

        if (prodotti.ContainsKey(prodotto))
        {
            Console.WriteLine("Il prodotto esiste già. Indica di quanto aumentarne la quantità");
            int incremento = int.Parse(Console.ReadLine()!);
            prodotti[prodotto] += incremento;
        }
        else
            prodotti.Add(prodotto, 1);
    }

    public static void RimuoviProdotto()
    {
        Console.WriteLine("Indica il prodotto da rimuovere");
        string prodotto = Console.ReadLine()!;

        if (prodotti.ContainsKey(prodotto))
        {
            prodotti.Remove(prodotto);
        }
        else
            Console.WriteLine("Prodotto non trovato");
    }

    public static void MostraProdotto()
    {
        Console.WriteLine("Indica il prodotto da mostrare");
        string prodotto = Console.ReadLine()!;

        if (prodotti.ContainsKey(prodotto))
            Console.WriteLine($"Ci sono {prodotti[prodotto]} di {prodotto}");
        else
            Console.WriteLine("Prodotto non trovato");
    }
}
