using EsercizioOperatore.Classi;

namespace EsercizioOperatore.Dati;

public static class ListaOperatori
{    
    public static Operatore operatoreEmergenza = new OperatoreEmergenza(
        "Mario", "Giorno", 1);

    public static Operatore operatoreSicurezza = new OperatoreSicurezza(
        "Giuseppe", "Notte", "Magazzino Verticale");

    public static Operatore operatoreLogistica = new OperatoreLogistica(
        "Paola", "Giorno", 33);

    public static List<Operatore> operatori = new()
    {
        operatoreEmergenza,
        operatoreSicurezza,
        operatoreLogistica
    };
}
