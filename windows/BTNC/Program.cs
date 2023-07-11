using BTNC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNC
{
  internal class Program
  {
    static void Main(string[] args)
    {
      BeeManager beeManager = new BeeManager();

      while (true)
      {
        Console.Clear(); // Clear the console screen

        Console.WriteLine("Please select an option:");
        Console.WriteLine("1 - Create bee list");
        Console.WriteLine("2 - Attack bees");
        Console.WriteLine("3 - Exit");

        string input = Console.ReadLine();

        switch (input)
        {
          case "1":
            beeManager.CreateBeeList();
            beeManager.DisplayBeeStatus();
            break;
          case "2":
            beeManager.AttackBees();
            beeManager.DisplayBeeStatus();
            break;
          case "3":
            return;
          default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
      }
    }
  }
}
