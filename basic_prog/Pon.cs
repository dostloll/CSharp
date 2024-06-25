using System;

namespace PositiveOrNot{
    class Prime{
        static void Main(string[] args){
            if(int.TryParse(Console.ReadLine(),out int a)){

                if(a>=0){
                    if(a==1){
                        Console.WriteLine("Not Prime.");
                    }
                    for(int i = 2;i<=Math.Sqrt(a);i++){
                        if(a%i==0){
                            Console.WriteLine("It is not prime");
                           
                        } else{
                             Console.WriteLine("It is prime.");
                        }
                    }
                   
                } else{
                    Console.WriteLine("Number is negative.");
                }
            }else{
                Console.WriteLine("Wrong Format.");
            }
        }
    }
}