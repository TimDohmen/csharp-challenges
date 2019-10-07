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
      System.Console.WriteLine(Challenges.doubleInteger(5.5));
      System.Console.WriteLine(Challenges.isNumEven(18));
      System.Console.WriteLine(Challenges.isNumEven(17));
      System.Console.WriteLine(Challenges.GetFileExt("hello.txt"));
      System.Console.WriteLine(Challenges.GetFileExt("hello.txt.bcw"));
      System.Console.WriteLine(Challenges.LongString(new string[] { "a", "b", "vc", "wond" }));
      System.Console.WriteLine(Challenges.ArraySum(new int[] { 6, 10, 12 }));


      System.Console.WriteLine("Part One - Double Integer");
      string choice = Console.ReadLine().ToLower();

      if (int.TryParse(choice, out int index))
      {
        System.Console.WriteLine(Challenges.doubleInteger(index));
      }
      else
      {
        System.Console.WriteLine("Enter a Number");
      }

      System.Console.WriteLine("Part Two - Is Number Even");
      string choiceTwo = Console.ReadLine().ToLower();
      if (int.TryParse(choice, out int indexTwo))
      {
        System.Console.WriteLine(Challenges.isNumEven(indexTwo));
      }
      else
      {
        System.Console.WriteLine("Enter a Number");
      }



    }
  }
}
