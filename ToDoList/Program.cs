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
      string stringAnswer = Console.ReadLine();
      string answer = stringAnswer.Replace(" ", "");
      if (answer == "Add" || answer == "add")
      {
        AddToList();
      } 
      else if (answer == "View" ||  answer == "view")
      {
        ViewTheList();
      } 
      else
      {
        ViewTheMenu();
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
      if (result.Count <= 0)
      {
        Console.WriteLine("Please add an item");
         ViewTheMenu();
      }
      else
      {
      for (int index = 0; index < result.Count; index++)
      {
        Console.WriteLine("___________________");
        Console.WriteLine((index+1) + "." + result[index].Description);
      }
        ViewTheMenu();
      }
    }
}
}