using EsercizioSoldato.Classi;

namespace EsercizioSoldato.Dati;

public static class InMemory
{
    public static class ListaSoldati
    {
        public static Soldato primoFante = new Fante(
            "Italia", "Mario Rossi", "Soldato Semplice", 2, "Cacciavite");

        public static Soldato primoArtigliere = new Artigliere(
            "Francia", "Jacques", "Soldato Semplice", 2, 50);

        public static List<Soldato> soldati = new()
        {
            primoFante,
            primoArtigliere
        };
    }
}
