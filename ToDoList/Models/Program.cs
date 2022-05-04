using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the ToDo list.");
      string check = "";

      while (check != "quit")
      {
        check = GetUserInput("Would you like to add an item to your list or view your list? (Add/View)");
        switch (check)
        {
          case "add":
            Item newItem = new Item(GetUserInput("Please enter the description for the new Item"));
            Console.WriteLine($"'{newItem.Description}' has been added to your list.");
            break;
          
          case "view":
            List<Item> items = Item.GetAll();
            int count = 1;
            foreach (Item item in items)
            {
              Console.WriteLine($"{count}. {item.Description}");
              count++;
            }
            break;
          
          default:
            Console.WriteLine("Invalid command ('quit' to exit program)"); break;
        }

        
      }
    }

    private static string GetUserInput(string message)
    {
      Console.WriteLine(message);
      string input = Console.ReadLine();
      input = input.ToLower();
      input = input.Trim();

      return input;
    }
  }
}
// if(check.ToLower() == "add")
// {
//   Console.WriteLine("Please enter the description for the new Item");
//   string task = Console.ReadLine();

//   Item newItem = new Item(task);
//   Console.WriteLine($"'{newItem.Description}' has been added to your list.");
// }
// else if (check.ToLower() == "view")
// {
//   List<Item> items = Item.GetAll();
//   int count = 1;
//   foreach (Item item in items)
//   {
//     Console.WriteLine($"{count}. {item.Description}");
//     count++;
//   }
// }