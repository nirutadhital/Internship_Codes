// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Reflection.Metadata.Ecma335;

interface IShape
{
    void Draw();
}
class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("Square is Drawing");
    }

}
class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("The rectangle is Drawing");
    }
}
class Circle: IShape
{
    public void Draw()
    {
        Console.WriteLine("The Circle is Drawing");
    }

}
class ShapeFactory
{
    public IShape GetShape(String ShapeType)
    {
        if(ShapeType==null)
        {
            return null;
        }
        if(ShapeType.Equals("Circle")){
            return new Circle();
        }
        if(ShapeType.Equals("Rectangle")){
            return new Rectangle();
        }
        if(ShapeType.Equals("Square")){
            return new Square();
        }
        return null;
    }
}

public class FactoryPatternDemo{
    static void Main()
    {
        ShapeFactory sf=new ShapeFactory();
        IShape s1=sf.GetShape("Circle");
        s1.Draw();
        IShape s2=sf.GetShape("Rectangle");
        s2.Draw();
        IShape s3=sf.GetShape("Sqaure");
        s3.Draw();
    }
}
