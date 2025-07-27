using System;
using System.Linq;
class Program
{



  static void Main()
  {
    List<string> heroes = new()
    {
      "Astra","Zephyr", "Nyx", "Orion", "Nova", "Thorne"
    };

    //  Aproach 1. 
    //  Without using LINQ.

    List<string> longLoudHeroes = new();

    foreach (var hero in heroes)
    {
      if (hero.Length > 5)
      {
        string formatted = hero.ToUpper();
        longLoudHeroes.Add(formatted);
      }
    }

    //  Approach 2.
    //  Using LINQ.

    var longLoudHeroes2 = from h in heroes where h.Length > 5 select h.ToUpper();

    //  Printing 
    Console.WriteLine("Your long loud heroes are..");

    foreach (var hero in longLoudHeroes2)
    {
      Console.WriteLine(hero);
    }
    {

    }

    var longHeroes3 = heroes.Where(n => n.Length > 7);
    Console.WriteLine(longHeroes3.Count());
  }

}