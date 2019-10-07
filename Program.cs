using System;

namespace morningChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      int doubleInteger(int num)
      {
        int sol = num + num;
        return sol;
      }

      System.Console.WriteLine("Part One");
      string choice = Console.ReadLine().ToLower();

      if (int.TryParse(choice, out int index))
      {

        System.Console.WriteLine(doubleInteger(index));
      }

    }
  }
}
