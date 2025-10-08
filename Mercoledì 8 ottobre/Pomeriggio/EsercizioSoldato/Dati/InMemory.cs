using EsercizioSoldato.Classi;

namespace EsercizioSoldato.Dati;

public static class InMemory
{
    public static class ListaSoldati
    {
        public static Soldato primoFante = new Fante(
            "Mario Rossi", "Soldato Semplice", 2, "Cacciavite");

        public static List<Soldato> soldati = new()
        {
            primoFante
        };
    }
}
