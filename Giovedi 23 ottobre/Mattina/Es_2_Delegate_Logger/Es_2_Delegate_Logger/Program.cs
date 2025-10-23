class Program
{
    delegate void Logger(string message);

    static void Main()
    {
        void StampaSuConsole(string message)
        {
            Console.WriteLine($"[CONSOLE]: {message}");
        }

        void LogFile(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }

        void EseguiLog(string message, Logger logger)
        {
            logger(message);
        }

        Logger stampaSuConsole = StampaSuConsole;
        Logger stampaSuFile = LogFile;        

        int input;
        string messageInput = "";
        do
        {
            Console.WriteLine("Scegli come loggare il messaggio:\n" +
            "1. Su console\n" +
            "2. Su File\n" +
            "0. Esci dal programma");

            input = int.Parse(Console.ReadLine()!);

            if (input != 0)
            {
                Console.WriteLine("Inserisci il messaggio da loggare");
                messageInput = Console.ReadLine()!;
            }

            switch (input)
            {
                case 1:
                    EseguiLog(messageInput, stampaSuConsole);
                    break;

                case 2:
                    EseguiLog(messageInput, stampaSuFile);
                    break;

                case 0:
                    Console.WriteLine("Uscita dal programma");
                    break;

                default:
                    Console.WriteLine("Input non valido");
                    break;
            }
        }
        while (input != 0);
    }
}