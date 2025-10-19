namespace _5_Design_Pattern.Utils;

public static class BeverageMapper
{
    public static readonly Dictionary<int, string> ListOfBeverages = new()
    {
        { 1, "Tea" },
        { 2, "Coffee" },

        //check availability
        //add availability

        { 0, "Exit" }
    };
}
