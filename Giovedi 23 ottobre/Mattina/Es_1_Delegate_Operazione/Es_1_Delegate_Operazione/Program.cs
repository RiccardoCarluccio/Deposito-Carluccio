class Program
{
    delegate int Operazione(int a, int b);

    static void Main()
    {
        int Somma(int a, int b)
        {
            return a + b;
        }

        int Moltiplicazione(int a, int b)
        {
            return a * b;
        }

        int EseguiOperazione(int a, int b, Operazione operazione)
        {
            return operazione(a, b);
        }

        Operazione op_somma = Somma;
        Console.WriteLine($"Somma tra 5 e 7: {op_somma(5, 7)}");
        Console.WriteLine($"Somma con 'EseguiOperazione: {EseguiOperazione(5, 7, op_somma)}");

        Console.WriteLine("");

        Operazione op_moltiplicazione = Moltiplicazione;
        Console.WriteLine($"Moltiplicazione tra 5 e 7: {op_moltiplicazione(5, 7)}");
        Console.WriteLine($"Moltiplicazione con 'EseguiOperazione: {EseguiOperazione(5, 7, op_moltiplicazione)}");
    }
}