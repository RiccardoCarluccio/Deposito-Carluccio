Persona persona_1 = new Persona("Mario", "Rossi", 1990);
Persona persona_2 = new Persona("Giuseppe", "Verdi", 1980);

Console.WriteLine($"{persona_1.Nome} {persona_1.Cognome} è nato nell'anno {persona_1.AnnoNascita}");
Console.WriteLine($"{persona_2.Nome} {persona_2.Cognome} è nato nell'anno {persona_2.AnnoNascita}");

Persona[] listaPersone = [persona_1, persona_2 ];

Console.WriteLine($"Ci sono {listaPersone.Length} persone nel database. Quale vuoi visualizzare?");
int input = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Hai deciso di visualizzare: {listaPersone[input].Nome}");
