interface IClient{
    void input(int a, int b);
    void output();
}
class Developer : IClient{
    int a;
    int b;
    public void input(int a, int b){
        this.a=a;
        this.b=b;
    }
    public void output(){
        Console.WriteLine(a+b);
    }
}