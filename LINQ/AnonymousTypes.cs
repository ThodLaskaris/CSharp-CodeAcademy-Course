// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace LearnLinq
// {
//   class Hero
//   {
//     public string Name;
//     public string Class;
//     public string Race;
//     public int Strength;
//     public int Wisdom;
//     public int Dexterity;

//     public Hero (string n, string c, string r, int s, int w, int d)
//     {
//       this.Name = n;
//       this.Class = c;
//       this.Race = r;
//       this.Strength = s;
//       this.Wisdom = w;
//       this.Dexterity = d;
//     }
//   }

//   class Program
//   {
//     static void Main()
//     {
//       Hero[] heroes = { 
//         new Hero("Zoe","Fighter","Dwarf",18,8,11), 
//         new Hero("Liam","Wizard","Elf",8,18,11), 
//         new Hero("Taryn","Thief","Hafling",11,8,18), 
//         new Hero("Dorian","Cleric","Human",8,18,11)};

//     var strongHeroes = from h in heroes
//       where h.Strength > 10
//       select new { h.Name, h.Class };

//     foreach (var h in strongHeroes)
//     {
//       Console.WriteLine($"{h.Name} {h.Class}");
//     }

//     }
//   }
// }
using System;

class Program
{
  static void Main(string[] args)
  {
    string[] heroes = { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };
    // method syntax transform each element .
    // Write a method syntax query that transforms each element in heroes to this format:
    var heroTransform = heroes.Select(h => new { $"Introducing ... {h}!" });
    // lambda expression
    var heroesToRename = heroes.Select(h => $"Introducing...{h}!");

    // Printing...
    foreach (var hero in heroesToRename)
    {
      Console.WriteLine(hero);
    }
    // returns index of element 
    var heroIndex = from h in heroes
                    where h.Contains("i")
                    select (h.IndexOf("i"));

    foreach (var index in heroIndex)
    {
      Console.WriteLine(index);
    }
  }
}