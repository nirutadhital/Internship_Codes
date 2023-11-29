class P{
    public void PShow(){
        Console.WriteLine("this is parent");
    }
}
class S : P{
    public void SShow(){
        Console.WriteLine("this is S");
    }
}
class D : P{
    public void DShow(){
        Console.WriteLine("this is D");
    }
}