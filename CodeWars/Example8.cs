using System;


class Example8
{
  public class Average
  {


    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
      float sum = 0;
      float average = 0;

      foreach (var points in ClassPoints)
      {
        sum += points; // Άθροισμα των βαθμών της τάξης

      }
      average = (YourPoints + sum) / (ClassPoints.Length + 1); // Μέσος όρος όλων των βαθμών (συμμαθητές + εσύ)
      return YourPoints > average;
      
      }
    }
  }
/*
acraileanu, b.safta, dramurai, brain6, ChingChangChong, eneb, j0h4n, ItisAsimulation, Myrkoholic, germi (+ 331)

using System.Linq;

public class Kata
{
  public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
  {
    return YourPoints > ClassPoints.Average();
  }
}
*/