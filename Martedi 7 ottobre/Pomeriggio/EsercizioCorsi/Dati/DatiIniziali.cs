using EsercizioCorsi.Corsi;

namespace EsercizioCorsi.Dati;

public static class DatiIniziali
{
    public static class ListeStudenti
    {
        public static List<string> studentiMusicaMandolino =
        [
            "Elena", "Valerio", "Valentina"
        ];

        public static List<string> studentiPitturaImpressionismo =
        [
            "Simone", "Lorenzo", "Pietro"
        ];

        public static List<string> studentiDanzaClassica =
        [
            "Andrea", "Marco", "Salvatore"
        ];
    }
    
    public static class ListaCorsi
    {
        public static CorsoMusica corsoMusicaMandolino = new CorsoMusica(
        1, "Corso di Mandolino", 900, "Marco Bianchi", ListeStudenti.studentiMusicaMandolino, "Mandolino");

        public static CorsoPittura corsoPitturaImpressionismo = new CorsoPittura(
            2, "Corso di Impressionismo", 900, "Paolo Rossi", ListeStudenti.studentiPitturaImpressionismo, "Impressionismo");

        public static CorsoDanza corsoDanzaClassica = new CorsoDanza(
            3, "Corso di Danza Classica", 900, "Giovanni Verdi", ListeStudenti.studentiDanzaClassica, "Classico");

        public static List<CorsoBase> corsi = new()
        {
            corsoMusicaMandolino,
            corsoPitturaImpressionismo,
            corsoDanzaClassica
        };
    }    
}
