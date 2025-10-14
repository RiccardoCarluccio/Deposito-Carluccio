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

public class ConcreteShapeCreator : ShapeCreator
{
    public override IShape CreateShape(string type)
    {
        switch (type.ToLower())
        {
            case "circle":
                return new Circle();

            case "square":
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
        ShapeCreator creator = new ConcreteShapeCreator();
        
        Console.WriteLine("Select the shape to draw\n" +
            "Circle, Square");
        string input = Console.ReadLine()!;

        IShape shape = creator.CreateShape(input);

        shape.Draw();
    }
}