// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
interface IShape
{
    void Draw();
}
class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Rectangle is drawing");
    }
}
class Square: IShape
{
    public void Draw()
    {
        Console.WriteLine("Square is Drawing");
    }
}
class RoundedRectangle: IShape
{
    public void Draw()
    {
        Console.WriteLine("RoundedRectangle is Drawing");

    }
}
class RoundedSquare: IShape
{
    public void Draw()
    {
        Console.WriteLine("RoundedSquare is Drawing");
    }

}
abstract class AbstractFactory
{
    public abstract IShape GetShape(string ShapeType); 
}

class ShapeFactory : AbstractFactory
{
    public override  IShape GetShape(String ShapeType)
    {
        if(ShapeType.Equals("Square"))
        {
            return new Square();
        }
         if(ShapeType.Equals("Rectangle"))
        {
            return new Rectangle();
        }
        return null;
    }
}

class RoundedShapeFactory : AbstractFactory
{
    public override IShape GetShape(String ShapeType)
    {
        if(ShapeType.Equals("RoundedSquare"))
        {
            return new RoundedSquare();
        }
         if(ShapeType.Equals("RoundedRectangle"))
        {
            return new RoundedRectangle();
        }
        return null;
    }
}

class FactoryProducer
{
    public static AbstractFactory GetFactory(bool rounded)
    {
        if(rounded)
        {
            return new RoundedShapeFactory();
        }
        else{
            return new ShapeFactory();
        }
    }
}

public class Program
{
    static void Main()
    {
        AbstractFactory af=FactoryProducer.GetFactory(false);
        IShape s1=af.GetShape("Rectangle");
        s1.Draw();
        IShape s2=af.GetShape("Square");
        s2.Draw();

        AbstractFactory af1=FactoryProducer.GetFactory(true);
        IShape r1=af1.GetShape("RoundedRectangle");
        r1.Draw();
        IShape r2=af1.GetShape("RoundedSquare");
        r2.Draw();
    }
}

