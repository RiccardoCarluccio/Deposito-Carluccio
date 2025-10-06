using EsempioStudente;

Studente studente_1 = new Studente("Mario", 1, 25.0);
Studente studente_2 = new Studente("Giuseppe", 2, 27.5);

Console.WriteLine($"Lo studente {studente_1.Nome} ha matricola: '{studente_1.Matricola}' e media voti: {studente_1.MediaVoti}");
Console.WriteLine($"Lo studente {studente_2.Nome} ha matricola: '{studente_2.Matricola}' e media voti: {studente_2.MediaVoti}");