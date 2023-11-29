using System;
namespace MethodGenerics{
    class Demo{
        public void Show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    // class MethodGenerics{
    //     static void Main(){
    //         Demo d=new Demo();
    //         d.Show<String>("this is demo");
    //         d.Show<int>(5);
    //         d.Show<double>(3.5);

    //     }
    // }
}