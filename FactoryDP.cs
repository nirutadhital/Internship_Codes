using System;
namespace FactoryDP
{
    interface IAnimal
    {
         void Sound();
    }
    class Dog: IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("the Dog says Woof Woof!!");
        }
    }

     class Cat: IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("the Cat says Meow Meow!!");
        }
    }
    abstract class AnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }
    class DogFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Dog();
        }
    }
    class CatFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Cat();
        }
    }

    // class Program{
    //     static void Main()
    //     {
    //         AnimalFactory af1=new DogFactory();
    //         IAnimal animal1 =af1.CreateAnimal();
    //         animal1.Sound();

    //         AnimalFactory af2=new CatFactory();
    //         IAnimal animal2 =af2.CreateAnimal();
    //         animal2.Sound();
    //     }
    // }
}