using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to the To Do List");
      ViewTheMenu();
    }
    static void ViewTheMenu(){
      Console.WriteLine("Would you like to add an item to your list or view your list? Type (Add/View)");
      string answer = Console.ReadLine();
      if (answer == "Add" || answer == "add")
      {
        AddToList();
      } 
      else if (answer == "View" ||  answer == "view")
      {
        ViewTheList();
      } 
    }
    static void AddToList()
    {
      Console.WriteLine("Please enter the description for the new item.");
      string answer = Console.ReadLine();
      Item itemList = new Item(answer);
      Console.WriteLine(answer + " has been added to your list. ") ;
      ViewTheMenu();
    }
    static void ViewTheList()
    {
      
      List<Item> result = Item.GetAll();
      Console.WriteLine(result[0]);
      ViewTheMenu();
    }
  }
}