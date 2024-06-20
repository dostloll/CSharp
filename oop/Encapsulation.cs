using System;
namespace EncapsulationExample
{
   public class Data{
    private string name;

    public void setName(string name){
        this.name = name;

    }
    public string getName(){
        return this.name;
    }
    }


    class Run{
      static void Main(string[] args){
        Data data = new Data();
        data.setName("Tero bau ho");
        Console.WriteLine(data.getName());
      }
    }
}