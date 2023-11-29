using System;
namespace Overloading{
class Shape{
    public void Area(int l){
        Console.WriteLine(l*l);
    }
    public void Area(int l,int b){
        Console.WriteLine(l*b);
    }
    public void Area(double r){
        Console.WriteLine(Math.PI*r*r);
    }
}
// public class Overloading{
//     static void Main(){
//        Shape sha=new Shape();
//         sha.Area(3);
//         sha.Area(3,4);
//         sha.Area(4.6);
//     }
// }
}


