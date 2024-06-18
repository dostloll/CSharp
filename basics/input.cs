using System;
namespace Input{
    class UsrInp{
        static void Main(String[] args){
            string UsrName;
            int age;
            Console.Write("Enter your username:");
            UsrName  =  Console.ReadLine();
            Console.Write("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Username: "+ UsrName+"\n"+"Age:"+age);
        }
    }
}