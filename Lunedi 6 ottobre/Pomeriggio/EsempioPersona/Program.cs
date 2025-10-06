Persona persona_1 = new Persona("Mario", "Rossi", 1990);
Persona persona_2 = new Persona("Giuseppe", "Verdi", 1980);

Console.WriteLine($"{persona_1.Nome} {persona_1.Cognome} è nato nell'anno: {persona_1.AnnoNascita}");
Console.WriteLine($"{persona_2.Nome} {persona_2.Cognome} è nato nell'anno: {persona_2.AnnoNascita}");

Persona[] listaPersone = [persona_1, persona_2 ];

int personaScelta;
while (true)
{
    Console.WriteLine($"Ci sono {listaPersone.Length} persone nel database. Quale vuoi visualizzare?");
    string? input = Console.ReadLine();

    if (int.TryParse(input, out personaScelta)
        && personaScelta >= 0
        && personaScelta <= listaPersone.Length)
    {
        personaScelta--;
        break;
    }
    else
        Console.WriteLine($"Input non valido. Sono presenti {listaPersone.Length} persone nel database");
}

Console.WriteLine($"Hai deciso di visualizzare: {listaPersone[personaScelta].Nome}");
Console.WriteLine($"{listaPersone[personaScelta].Nome} {listaPersone[personaScelta].Cognome} è nato nell'anno: {listaPersone[personaScelta].AnnoNascita}");
