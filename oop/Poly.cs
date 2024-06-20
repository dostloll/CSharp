using System;
using System.Collections.Generic;

namespace Poly{
    public class Animal {
        public virtual void MakeSound(){
            Console.WriteLine("Animal makes noise.");
        }
    }

    public class Dog:Animal{
        public override void MakeSound(){
            Console.WriteLine("Dog barks.");
        }
    }
    public class Cat:Animal{
        public override void MakeSound(){
            Console.WriteLine("Cat meows.");
        }
    }

    public class Run{
        static void Main(string[] args){
            List<Animal> animals = new List<Animal>{
                new Dog(),
                new Cat()
            };

            foreach(Animal animal in animals){
                animal.MakeSound();
            }
        }
    }
    
}

