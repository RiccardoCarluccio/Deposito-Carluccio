using _5_Design_Pattern.Decorator;
using _5_Design_Pattern.Factory;
using _5_Design_Pattern.Singleton;
using _5_Design_Pattern.Strategy;
using _5_Design_Pattern.Utils;

var instance = CoffeeMachine.Instance;
var beverages = BeverageMapper.ListOfBeverages;
var ingredients = IngredientMapper.ListOfIngredients;
var preparations = PreparationMapper.ListOfPreparations;

IBeverage? beverage = null;

var strategy = new PreparationStrategy();

int input;
string userChoice = "";
do
{
    Console.WriteLine("List of available beverages:");
    Console.WriteLine(string.Join("\n", beverages
        .Select(b => $"{b.Key}. {b.Value}")));
    Console.Write("Choose the number of your choice: ");
    input = int.Parse(Console.ReadLine()!);        //switch to nullable?

    if (beverages.ContainsKey(input))
    {
        userChoice = beverages[input];
    }

    if (instance.CheckAvailability(userChoice))
    {
        switch (input)
        {
            case 1:
                beverage = BeverageFactory.MakeBeverage(userChoice);        //refactor to use only 1 case/if
                instance.RemoveAvailability(userChoice);
                break;

            case 2:
                beverage = BeverageFactory.MakeBeverage(userChoice);
                instance.RemoveAvailability(userChoice);
                break;

            case 0:
                Console.WriteLine("Closing the program");
                break;

            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
    else
    {
        Console.WriteLine($"There is no more {userChoice}");
        break;
    }
}
while (!beverages.ContainsKey(input));

if (beverage == null)
    return;

do
{
    Console.WriteLine("\nList of ingredients:");
    Console.WriteLine(string.Join("\n", ingredients
        .Select(i => $"{i.Key}. {i.Value}")));
    Console.Write("Choose the number of your choice: ");
    input = int.Parse(Console.ReadLine()!);

    switch (input)
    {
        case 1:
            beverage = new SugarDecorator(beverage);
            break;

        case 2:
            beverage = new MilkDecorator(beverage);
            break;

        case 0:
            Console.WriteLine("Closing the program");
            break;

        default:
            Console.WriteLine("Invalid input");
            break;
    }
}
while (input != 0);

do
{
    Console.WriteLine("\nChoose your preparation:");
    Console.WriteLine(string.Join("\n", preparations
        .Select(p => $"{p.Key}. {p.Value}")));
    Console.Write("Choose the temperature of your beverage: ");
    input = int.Parse(Console.ReadLine()!);

    switch (input)
    {
        case 1:
            strategy.SetStrategy(new HotPreparation());
            break;

        case 2:
            strategy.SetStrategy(new ColdPreparation());
            break;

        case 0:
            Console.WriteLine("Exiting the application");
            break;

        default:
            Console.WriteLine("Invalid input");
            continue;
    }
    Console.WriteLine("");
    strategy.ExecuteStrategy(beverage);
    break;
}
while (true);

//ask to confirm choice || go back || go to the first menu || remove ingredient