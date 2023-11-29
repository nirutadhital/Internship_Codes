using System;
namespace Overriding{
    class Animal{
        public virtual void Sound(){
            Console.WriteLine("Animal makes sound");
        }
    }
    class Dog : Animal{
        public override void Sound(){
            Console.WriteLine("the dog says woof woof");
        }
    }
    class Cat: Animal{
        public override void Sound()
        {
            Console.WriteLine("Cat says meow meow");
        }
    }
//     public class Overriding{
//     static void Main(){
//         Animal a=new Animal();
//         Dog d=new Dog();
//         Cat c=new Cat();
//         a.Sound();
//         d.Sound();
//         c.Sound();
//     }
// }
}