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
class Meal
{
    private List<Item> items = new ArrayList<Item>();	

   public void addItem(Item item){
      items.add(item);
   }

   public float getCost(){
      float cost = 0.0f;
      
      for (Item item : items) {
         cost += item.price();
      }		
      return cost;
   }
     public void showItems(){
   
      for (Item item : items) {
         Console.WriteLine("Item : " + item.name());
         Console.WriteLine(", Packing : " + item.packing().pack());
         Console.WriteLine(", Price : " + item.price());
      }		
   }
   class MealBuilder
   {
    public MealBuilder()
    {
        
    }
    
   }
    
}


class BuilderPatternDemo
{
    public BuilderPatternDemo()
    {
        
    }
}