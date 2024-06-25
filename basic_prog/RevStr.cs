using System;

namespace StrRev{
    class Reverse{
        static void Main(string[] args){
           string input = Console.ReadLine();
           char[] str = input.ToCharArray();
           Array.Reverse(str);
           Console.WriteLine(new string(str));

        }
    }  
}