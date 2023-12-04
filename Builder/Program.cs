// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Reflection.Emit;
using System.Runtime.Intrinsics.Wasm;

public interface IItem
{
    public string name();
    public IPacking packing();
    public float price();
}
public interface IPacking
{
    public string pack();
}
class Wrapper : IPacking
{
    public string pack()
    {
        return "Wrapper";

    }
}
class Bottle : IPacking
{
    public string pack()
    {
        return "Bottle";
    }
}

abstract class Burger : IItem
{
    
    public IPacking packing()
    {
        return new Wrapper();
    }
    public abstract float price();
    public abstract string name();
}

abstract class ColdDrink : IItem
{
    public IPacking packing()
    {
        return new Bottle();
    }
    public abstract float price();
    public abstract string name();
}

class VegBurger : Burger
{
    public override float price()
    {
        return 25.0f;
    }
    public override string name()
    {
        throw new NotImplementedException();
        return "Veg Burger";
    }
}

class ChikenBurger : Burger
{
     public override float price()
    {
        return 35.0f;
    }
    public override string name()
    {
        throw new NotImplementedException();
        return "Chicken Burger";
    }
}

class Pepsi : ColdDrink
{
    public override float price()
    {
        return 10.0f;

    }
    public override string name()
    {
        return "Pepsi";
    }
}

class Coke : ColdDrink
{
    public override float price()
    {
        return 15.0f;

    }
    public override string name()
    {
        return "Coke";
    }
}


class BuilderPatternDemo
{
    public BuilderPatternDemo()
    {
        int a=a+1;
        
    }
}