using System;

class Program
{

  static void Main(string[] args)
  {


    MoonRover lunokhod = new("Lunokhod 1", 1970);
    MoonRover apollo = new("Apollo 15", 1971);
    MarsRover sojourner = new("Sojourner", 1997);
    Satellite sputnik = new("Sputnik", 1957);


    Rover[] rovers = new Rover[] { lunokhod, apollo, sojourner };
     DirectAll(rovers);
    Object[] probles = new Object[] { lunokhod, apollo, sojourner, sputnik };
    foreach (var proble in probles)
    {
      Console.WriteLine(proble.getType());
    }
  }

  public static void DirectAll(Rover[] rovers)
  {

    foreach (var rover in rovers)
    {
      rover.GetInfo();
      rover.Explore();
      rover.Collect();
    }
  }


}