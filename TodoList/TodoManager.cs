using System;
using System.Collections.Generic;

namespace TodoListManager{
   public class TodoManager{

    private List<TodoItem> _items;
    private int _nextId;

    public TodoManager(){
        _items = new List<TodoItem>();
        _nextId = 1;

    }

    public void AddTodoItem(string description){
     var item = new TodoItem(_nextId++,description);
     _items.Add(item);
    }

    public void RemoveTodoItem(int id){
        _items.RemoveAll(items => items.Id ==id);
    }

    public void MarkItemsAsCompleted(int id){
        var itemsToComplete = _items.Find(items => items.Id == id);
        if(itemsToComplete != null){
            itemsToComplete.IsComplete = true;
        }
    }

    public void DisplayTodoItems(){
        Console.WriteLine("TODO list:");
        foreach (var items in _items){
            Console.WriteLine(items);
        }
    }
    }
}