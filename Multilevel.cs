class Parent{
    public void ParentShow(){
        Console.WriteLine("I am parents");
    }
}
class Son1 : Parent{
    public void Son1Show(){
        Console.WriteLine("I am Son1");
    }
}
class Son2 : Son1{
    public void Son2Show(){
        Console.WriteLine("I am Son2");
    }
}