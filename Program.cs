using System;
using morningChallenge.Models;

namespace morningChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      System.Console.WriteLine(Challenges.doubleInteger(10));
      System.Console.WriteLine(Challenges.isNumEven(18));

      //   System.Console.WriteLine("Part One - Double Integer");
      //   string choice = Console.ReadLine().ToLower();

      //   if (int.TryParse(choice, out int index))
      //   {

      //     System.Console.WriteLine(doubleInteger(index));
      //   }

      //   System.Console.WriteLine("Part Two - Is Number Even");
      //   string choiceTwo = Console.ReadLine().ToLower();


    }
  }
}
