using Es_DuePattern.Interfacce;

namespace Es_DuePattern.Classi;

public class Veicoli
{
    public class Auto : IVeicolo
    {
        public void Avvia()
        {
            Console.WriteLine("Avvio dell'auto");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo: Auto");
        }
    }

    public class Moto : IVeicolo
    {
        public void Avvia()
        {
            Console.WriteLine("Avvio della moto");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo: Moto");
        }
    }

    public class Camion : IVeicolo
    {
        public void Avvia()
        {
            Console.WriteLine("Avvio del camion");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo: Camion");
        }
    }
}
