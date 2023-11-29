abstract class Animal{
    //abstract method
    public abstract void animalSound();
    //regular method
    public void sleep(){
        Console.WriteLine("the animal is sleeping");
    }
}
class Dog : Animal{
    public override void animalSound()
    {
        //throw new NotImplementedException();
        Console.WriteLine("The dog is sleeping");
    }
}




  