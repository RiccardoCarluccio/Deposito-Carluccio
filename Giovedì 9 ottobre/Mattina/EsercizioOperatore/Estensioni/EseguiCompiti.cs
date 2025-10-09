using EsercizioOperatore.Classi;

namespace EsercizioOperatore.Estensioni;

public static class EseguiCompiti
{
    public static void EseguiCompitoOperatore(Operatore operatore)
    {
        operatore.EseguiCompito();
        operatore.EseguiCompito(operatore.Nome);
    }

    public static void MostraCompitoOperatore(List<Operatore> operatori)
    {
        Console.WriteLine("Inserisci il nome dell'operatore per saperne il compito");
        string nomeOperatore = Console.ReadLine()!;
        Console.WriteLine("");

        var operatoreEsistente = operatori.FirstOrDefault(o => o.Nome == nomeOperatore);
        if (operatoreEsistente is not null)
        {
            EseguiCompitoOperatore(operatoreEsistente);
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine($"L'operatore di nome {nomeOperatore} non è stato trovato");
        }
    }
}
