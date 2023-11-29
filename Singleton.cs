using System;
namespace Singleton {
    public sealed class Singleton{
        private static int counter=0;
        private static Singleton instance=null;
        public static Singleton getInstance
        {
            get
            {
                if(instance==null){
                    instance=new Singleton();
                }
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value: "+counter.ToString());
        }
        public void printDetails(String msg)
        {
            Console.WriteLine(msg);
        }

    }
    // public class Demo{
    //     static void Main()
    //     {
    //         Singleton s1=Singleton.getInstance;
    //         s1.printDetails("I am S1");
    //         Singleton s2=Singleton.getInstance;
    //         s2.printDetails("I am S2");

    //     }
    // }
}