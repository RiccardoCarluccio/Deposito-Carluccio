namespace _5_Design_Pattern.Utils;

public static class IngredientMapper
{
    public static readonly Dictionary<int, string> ListOfIngredients = new()
    {
        { 1, "Sugar" },
        { 2, "Milk" },
                                                //add "remove ingredient
        { 0, "Stop adding ingredients" }
    };
}
