using System;
namespace Casting{
    class Cast{
        static void Main(String[] args){
            int aInt = 5;
            double bDouble = aInt;//Automatic casting.
            Console.WriteLine(aInt.GetType().Name +" changed to "+bDouble.GetType().Name);
            Console.Write("Values are "+aInt+" of Integer changed to " + bDouble+" of double.");
        }
    }
}