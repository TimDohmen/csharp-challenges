using System.Collections.Generic;
using System.Linq;

namespace morningChallenge.Models
{
  public class Challenges
  {


    public static int doubleInteger(int num)
    {
      int sol = num + num;
      return sol;
    }
    public static float doubleInteger(float num)
    {
      return num + num;
    }
    public static double doubleInteger(double num)
    {
      return num + num;
    }

    public static bool isNumEven(int num)
    {
      return num % 2 == 0;
    }
    public static bool isNumEven(float num)
    {
      return num % 2 == 0;
    }
    public static bool isNumEven(double num)
    {
      return num % 2 == 0;
    }

    public static string GetFileExt(string x)
    {
      string[] fileName = x.Split('.');
      if (fileName.Length > 1)
      {
        // return fileName[fileName.Length - 1];
        //^means start from end and work way back from there
        return fileName[^1];
      }
      return null;
    }

    public static string LongString(string[] x)
    {
      string longest = "";
      for (int i = 0; i < x.Length; i++)
      {
        string current = x[i];
        if (current.Length > longest.Length)
        {
          longest = current;
        }
      }
      return longest;
    }

    public static int ArraySum(int[] x)
    {
      int sum = 0;
      for (int i = 0; i < x.Length; i++)
      {
        sum += x[i];
      }


      return sum;
    }
    public static float ArraySum(float[] x)
    {
      float sum = 0;
      for (int i = 0; i < x.Length; i++)
      {
        sum += x[i];
      }


      return sum;
    }
    public static double ArraySum(double[] x)
    {
      double sum = 0;
      for (int i = 0; i < x.Length; i++)
      {
        sum += x[i];
      }


      return sum;
    }

    public static List<List<int>> ArrayGrouper(int[] arr)
    {
      Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
      foreach (int num in arr)
      {
        // if (dict.ContainsKey(num))
        // {
        //   dict[num].Add(num);
        // }
        // else
        // {
        //   dict.Add(num, new List<int>());
        //   dict[num].Add(num);
        // }

        if (dict.ContainsKey(num))
        {
          dict.Add(num, new List<int>());
        }
        7
        dict[num].Add(num);

      }

      return dict.Values.ToList();


    }

    public static int[][] Grouper(int[] arrOld)
    {
      Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
      foreach (int num in arrOld)
      {
        if (dict.ContainsKey(num))
        {
          dict.Add(num, new List<int>());
        }
        dict[num].Add(num);
      }
      var values = dict.Values.ToList();
      var intList = new List<int[]>();
      values.ForEach(v => intList.Add(v.ToArray()));
      return intList.ToArray();

    }
  }
}