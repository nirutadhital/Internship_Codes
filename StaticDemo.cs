using System;
namespace StaticDemo{
    class Student{
        //non static methods and variables
        public String name="";
        public int age;
        public void Info(String name, int age){
            this.name=name;
            this.age=age;
        }
        public void Show(){
            Console.WriteLine("the name is: "+name+"\nthe age is: "+age);
        }

        //static mehtods and variables
        public static String username="";
        public static String password="";
        public static void AdminCred(){
            Console.WriteLine("the username is:"+username+"\nThe password is:"+password);
        }
    }

    // public class StaticDemo{
    //     static void Main(){
    //         Student s=new Student();
    //         s.Info("john",7);
    //         s.Show();
    //         Student.username="niruta";
    //         Student.password="niruta@123";
    //        s Student.AdminCred();
    //     }
    // }
}