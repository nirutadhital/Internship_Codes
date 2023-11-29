using System;
namespace ParameterizedConstruct{
    class Car{
        public string color;
        public string model;

        public Car(string color, string model){
            this.color=color;
            this.model=model;
        }
    }
    // public class DefaultConstructor{
    //     static void Main(){
    //         Car c=new Car("RED","FORD");
    //         Console.WriteLine("The color of the car is "+c.color+"\nThe Model is "+c.model);
    //     }
    // }
}