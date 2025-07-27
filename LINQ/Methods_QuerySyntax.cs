using System;

class Program
{
  static void Main(string[] args)
  {
    string[] heroes = { "Zoe", "Liam", "Tyran", "Dorain", "Everset", "Marlena" };

    //  Query Syntax.

    var queryResult = from x in heroes where x.Contains("a") select $"{x} contains an 'a'";

    //  Method Syntax.

    var methodResult = heroes
    .Where(x => x.Contains("a"))
    .Select(x => $"{x} contains an 'a'");

    //  Printing..

    console.WriteLine("queryResult");
    foreach (var s in queryResult)
    {
      Console.WriteLine(s);
    }
  }
}