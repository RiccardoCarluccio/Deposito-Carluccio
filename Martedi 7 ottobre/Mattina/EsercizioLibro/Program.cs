using EsercizioLibro;

Libro libro_1 = new Libro(
    "Cent'anni di Solitudine",
    "Gabriel García Márquez",
    1967);

Libro libro_2 = new Libro(
    "Cent'anni di Solitudine",
    "Gabriel García Márquez",
    1967);

Libro libro_3 = new Libro(
    "Watchmen",
    "Alan Moore",
    1986);

List<Libro> listaLibri = [libro_1, libro_2, libro_3];

//Console.WriteLine($"Ci sono {listaLibri.Count} nel database");

//string nuovoTitolo;
//string nuovoAutore;
//int nuovoAnnoPubblicazione;

//Console.WriteLine("Per aggiungere un libro, inizia scrivendone il titolo");
//nuovoTitolo = Console.ReadLine()!;
//Console.WriteLine("Ora scrivi il suo autore");
//nuovoAutore = Console.ReadLine()!;
//Console.WriteLine("Adesso il suo anno di pubblicazione");
//nuovoAnnoPubblicazione= int.Parse(Console.ReadLine()!);

//Libro nuovoLibro = new Libro(
//    nuovoTitolo,
//    nuovoAutore,
//    nuovoAnnoPubblicazione);

//listaLibri.Add(nuovoLibro);

Console.WriteLine("Overridden 'ToString()'");
Console.WriteLine(libro_1);
Console.WriteLine(libro_2);
Console.WriteLine(libro_3);

Console.WriteLine("\nOverridden 'Equals()'");
Console.WriteLine(libro_1.Equals(libro_2));
Console.WriteLine(libro_1.Equals(libro_3));

Console.WriteLine("\nOverridden 'GetHashCode()'");
Console.WriteLine(libro_1.GetHashCode());
Console.WriteLine(libro_2.GetHashCode());
Console.WriteLine(libro_3.GetHashCode());