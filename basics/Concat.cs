using System;
namespace Concatination{
    class StrConcat{
        static void Main(String[] args){
            string name= "Dost";
            string surName = "Lol";
            string conc = string.Concat(name,surName);
            Console.Write(conc);
        }
    }
}