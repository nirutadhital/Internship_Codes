interface IP1{
     void IP1Show();
}
interface IP2{
     void IP2Show();
}
class Children : IP1 , IP2{
    public void IP1Show(){
        Console.WriteLine("I am IP1 show");
    }
    public void IP2Show(){
        Console.WriteLine("I am IP2 show");
    }

}