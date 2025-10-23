namespace Es_3_Delegate_Factory_DInjection.DependencyInjection;

public interface IDiscountPolicy
{
    decimal Sconta(decimal importo);
}

public class NoSconto : IDiscountPolicy
{
    public decimal Sconta(decimal importo)
    {
        return importo;
    }
}

public class Scontato : IDiscountPolicy
{
    public decimal Sconta(decimal importo)
    {
        return importo * 0.9m;
    }
}