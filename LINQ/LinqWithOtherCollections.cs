using System;

class Program
{
  static void Main(string[] args)
  {
    List<string> heroesList = new List<string> { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };

    // query to find all hero names that contain the letter v or y.
    var heroesWithVOrY = from h in heroesList
                         where h.Contains("v") || h.Contains("y")
                         select h;

    var heroesWithYOrVMethod = heroesList
   .Where(h => h.Contains("v") || h.Contains("y"));
    foreach (var hero in heroesWithYOrVMethod)
    {
      Console.WriteLine(hero);
    }
    }
}