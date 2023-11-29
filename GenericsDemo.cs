using System;
namespace GenericsDemo{
    //T is a data type
    class Demo<T>{
        public Demo(T msg){
            Console.WriteLine(msg);
        }
    }
    // class GenericsDemo{
    //     static void Main(){
    //         Demo<String> s=new Demo<string>("I am Demo String");
    //         Demo<int> i=new Demo<int>(4);
    //         Demo<double> d=new Demo<double>(5.5);
    //     }
    // }
}