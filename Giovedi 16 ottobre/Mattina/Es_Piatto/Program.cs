using Es_Piatto.Factories;

Console.WriteLine("Scegli il piatto\n" +
    "Pizza, Hamburger, Insalata");

string sceltaPiatto = Console.ReadLine()!;

IPiatto piatto = PiattoFactory.CreaPiatto(sceltaPiatto);

string preposizioni = "";
if (sceltaPiatto == "pizza" || sceltaPiatto == "insalata")
    preposizioni = "alla tua";
else if (sceltaPiatto == "hamburger")
    preposizioni = "al tuo";

Console.WriteLine($"Scegli gli ingredienti da aggiungere {preposizioni} {sceltaPiatto}\n" +
    $"1. Formaggio\n" +
    $"2. Bacon\n" +
    $"3. Salsa");
string sceltaIngrediente = Console.ReadLine()!;