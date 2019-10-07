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

  }
}