using EsercizioEsame.Classi;

namespace EsercizioEsame.Dati;

public static class InMemory
{
    public static class ListaAnimali
    {
        public static Gatto primoGatto = new Gatto(
            "Gatto", 3, "Arancione");

        public static Pinguino primoPinguino = new Pinguino(
            "Pinguino", 3, 10);

        public static List<Animale> animali = new()     //polimorfismo
        {
            primoGatto,
            primoPinguino
        };
    }
}
