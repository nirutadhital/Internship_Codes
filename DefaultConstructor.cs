using System;
namespace DefaultConstructor{
    class Car{
        public string color;
        public string model;

        public Car(){
            color="BLACK";
            model="KIA";
        }
    }
    // public class DefaultConstructor{
    //     static void Main(){
    //         Car c=new Car();
    //         Console.WriteLine("The color of the car is "+c.color+"\nThe Model is "+c.model);
    //     }
    // }
}