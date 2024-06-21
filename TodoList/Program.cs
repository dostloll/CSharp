using System;
using System.Collections.Generic;

namespace TodoListManager{
    class Program{
        static void Main(string[] args){
            var manager = new TodoManager();
            bool exit = false;

            while(!exit){
                Console.WriteLine("TODO List Manager");
                Console.WriteLine("1. Add TODO Item");
                Console.WriteLine("2. Remove TODO Item");
                Console.WriteLine("3. Mark TODO Item as Completed");
                Console.WriteLine("4. Display TODO Items");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                var choice = Console.ReadLine();

                switch (choice){
                    case "1":
                    Console.WriteLine("Enter the description of the TODO item:");
                    var description = Console.ReadLine();
                    manager.AddTodoItem(description);
                    break;

                    case "2":
                    Console.WriteLine("Enter ID of the TODO item to remove:");
                    if(int.TryParse(Console.ReadLine(),out int removeID)){
                        manager.RemoveTodoItem(removeID);
                    }else{
                        Console.WriteLine("Invalid ID.");
                    }
                    break;
                    case "3":
                    Console.Write("Enter the ID of the TODO item to mark as completed: ");
                    if(int.TryParse(Console.ReadLine(),out int completeId)){
                        manager.MarkItemsAsCompleted(completeId);
                    }else{
                        Console.WriteLine("Invalid ID.");
                    }
                    break;
                    case "4":
                    manager.DisplayTodoItems();
                    break;
                    case "5":
                    exit = true;
                    break;
                    default:
                    Console.WriteLine("Invalid choice. Please choose a valid option");
                    break;
                }
            }
        }
    }
}