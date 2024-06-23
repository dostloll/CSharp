using System;
using System.Collections.Generic;

namespace CompareParsh{
    class DoIt{
        static void Main(String[] args){
            string a;
            Console.Write("Enter a number of int only:");
            a = Console.ReadLine();
            if(int.TryParse(a,out int b)){
                Console.WriteLine("Correct Format.");
                Console.WriteLine("The number is :"+ b);
            }else{
                Console.WriteLine("Wrong format.");
                Console.WriteLine("You typed "+a+" which is incorrect format.");
            }
        }
    }
}