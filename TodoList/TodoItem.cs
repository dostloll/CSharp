using System;

namespace TodoListManager{
    public class TodoItem{
        public int Id {get;set;}
        public string Description {get;set;}
        public bool IsComplete {get;set;}

        public TodoItem(int id , string description){
            Id = id;
            Description = description;
            IsComplete = false;
        }

        public override string ToString(){
            return $"{Id}. {Description} - {(IsComplete ? "Completed":"Pending")}";
        }
    }
}