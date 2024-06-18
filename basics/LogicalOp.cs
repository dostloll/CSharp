using System;
namespace Logic{
    class BoolOp{
        static void Main(String[] args){
            Random random = new Random();
            bool a = random.Next(0,4)==0;
            Console.Write(a);
        }
    }
}