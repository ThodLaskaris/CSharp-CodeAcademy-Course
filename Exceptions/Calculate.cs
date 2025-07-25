using System;

class Program
{
  public static void ProccessData()
  {
    Calculate();
  }
  public static void Calculate()
  {
    throw new Exception("An error occured.");
  }
  static void Main(string[] args)
  {
    ProccessData();
    try
    {
      ProccessData();
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Exception caught in Main: {ex.Message}");
    }
  }
}