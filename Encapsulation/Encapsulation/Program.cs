using System;
using System.Runtime;

class Program
{
  static void Main(string[] args)
  {
    Profile sam = new("Sam Drakila", 30, "Greece", "Athens", "he/him");
    Console.WriteLine(sam.ViewProfile());
    System.Console.WriteLine();
    // Adding hobbies
    sam.SetHobbies(new string[] { "Reading", "Gaming", "Hiking" });
    Console.WriteLine(sam.ViewProfile());
  }
  
}
