using Es_Piatto.Factories;

namespace Es_Piatto.Decorators;

public abstract class IngredienteExtra : IPiatto
{
    protected IPiatto _componente;

    protected IngredienteExtra(IPiatto piatto)
    {
        _componente = piatto;
    }

    public virtual string Descrizione()
    {
        throw new NotImplementedException();
    }

    public virtual string Prepara()
    {
        throw new NotImplementedException();
    }
}

public class ConFormaggio : IngredienteExtra
{
    public ConFormaggio(IPiatto piatto)
        : base(piatto)
    {
    }

    public override string Descrizione()
    {
        return base.Descrizione() + "con formaggio\n";
    }
}

public class ConBacon : IngredienteExtra
{
    public ConBacon(IPiatto piatto)
        : base(piatto)
    {
    }

    public override string Descrizione()
    {
        return base.Descrizione() + "con bacon\n";
    }
}

public class ConSalsa : IngredienteExtra
{
    public ConSalsa(IPiatto piatto)
        : base(piatto)
    {
    }

    public override string Descrizione()
    {
        return base.Descrizione() + "con salsa\n";
    }
}