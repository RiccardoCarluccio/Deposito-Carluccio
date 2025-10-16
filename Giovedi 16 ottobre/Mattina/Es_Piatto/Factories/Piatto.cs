namespace Es_Piatto.Factories;

public class Piatto
{
    public class Pizza : IPiatto
    {
        public string Descrizione()
        {
            return "Pizza";
        }

        public string Prepara()
        {
            throw new NotImplementedException();
        }
    }

    public class Hamburger : IPiatto
    {
        public string Descrizione()
        {
            return "Hamburger";
        }

        public string Prepara()
        {
            throw new NotImplementedException();
        }
    }

    public class Insalata : IPiatto
    {
        public string Descrizione()
        {
            return "Insalata";
        }

        public string Prepara()
        {
            throw new NotImplementedException();
        }
    }
}
