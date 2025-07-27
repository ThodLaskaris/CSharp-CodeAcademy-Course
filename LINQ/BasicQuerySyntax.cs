using System;


/*

The from operator declares a variable to iterate through the sequence. In this case, h is used to iterate through heroes.

The where operator picks elements from the sequence if they satisfy the given condition. The condition is normally written like the conditional expressions you would find in an if statement. In this case, the condition is h.Length < 7.

The select operator determines what is returned for each element in the sequence. In this case, it’s just the element itself.
*/
class Program
{
  static void Main(string[] args)
  {
    string[] heroes = { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };


    var gHero = from h in heroes
                where h.Contains("i")
                select h;
    foreach (var hero in heroes)
    {
      Console.WriteLine(hero);
    }

    var underscore = from h in heroes
                     where h.Contains("a")
                     select h.Replace("a", "_");

    var underscored = from h in heroes
                      select h.Replace("a", "_");


    // var shortHeroes = heroes.Where(h => h.Length > 7)
    var heroesWithR = heroes.Where(h => h.Contains("r"));
    var lowerHeroesWithR = heroesWithR.Select(h => h.ToLower());

    /*

      // Separate statements
      var heroesWithR = heroes.Where(h => h.Contains("r"));
      var lowerHeroesWithR = heroesWithR.Select(h => h.ToLower());
    
      // Chained expressions
      var sameResult = heroes   
        .Select(h => h.ToLower())
        .Where(h => h.Contains("r"));
      
      foreach (var hero in sameResult)
      {
        Console.WriteLine(hero);
    */
  }
}