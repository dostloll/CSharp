namespace Inheritance{
    public class Vehicle{
        public string Brand {get;set;}
        public int Year {get;set;}

        public void DisplayInfo(){
            System.Console.WriteLine($"Brand:{Brand} \n Year: {Year}");
        }
    }

   public class Car:Vehicle{
    public int NumberOfDoors{get;set;}
    public void DisplayCarInfo(){
        DisplayInfo();
        System.Console.WriteLine($"Number of Doors: {NumberOfDoors}");
    }
   }

   public class Run{
    static void Main(string[] args){
        Car car = new Car{
            Brand = "Buggati",
            Year = 2024,
            NumberOfDoors = 2
        };

        car.DisplayCarInfo();
    }
   }

}