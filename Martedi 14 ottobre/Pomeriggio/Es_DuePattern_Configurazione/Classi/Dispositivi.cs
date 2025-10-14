using Es_DuePattern_Configurazione.Interfacce;

namespace Es_DuePattern_Configurazione.Classi;

public class Dispositivi
{
    public class Computer : IDispositivo
    {
        public void Avvia()
        {
            Console.WriteLine("Il computer si avvia");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo: computer");
        }
    }

    public class Stampante : IDispositivo
    {
        public void Avvia()
        {
            Console.WriteLine("La stampante si accende");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo: stampante");
        }
    }
}
