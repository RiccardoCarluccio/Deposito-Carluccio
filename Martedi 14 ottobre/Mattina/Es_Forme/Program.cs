public interface IShape
{
    void Draw();
}

public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("You drew a circle");
    }
}

public class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("You drew a square");
    }
}

public abstract class ShapeCreator
{
    public abstract IShape CreateShape(string type);
}

public class ConcreteShapeCreator_1 : ShapeCreator
{
    public override IShape CreateShape(string type)
    {
        switch (type.ToLower())
        {
            case "circle":
                Console.WriteLine("Creator 1");
                return new Circle();

            case "square":
                Console.WriteLine("Creator 1");
                return new Square();

            default:
                Console.WriteLine("Invalid type");
                return null;
        }
    }
}

public class ConcreteShapeCreator_2 : ShapeCreator
{
    public override IShape CreateShape(string type)
    {
        switch (type.ToLower())
        {
            case "circle":
                Console.WriteLine("Creator 2");
                return new Circle();

            case "square":
                Console.WriteLine("Creator 2");
                return new Square();

            default:
                Console.WriteLine("Invalid type");
                return null;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Select the creator\n" +
            "1, 2");
        int creatorChoice = int.Parse(Console.ReadLine()!);

        if (creatorChoice != 1 || creatorChoice != 2)
        {
            ShapeCreator creator = creatorChoice == 1 ? new ConcreteShapeCreator_1() : new ConcreteShapeCreator_2();

            Console.WriteLine("Select the shape to draw\n" +
                "Circle, Square");
            string input = Console.ReadLine()!;

            IShape shape = creator.CreateShape(input);

            shape.Draw();
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
        
    }
}