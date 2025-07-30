using System;

class Program
{
  static IEnumerable<IEnumerable<int>> ListOfLists()
  {
    yield return new List<int> { 1, 2, 3 };
    yield return new List<int> { 4, 5, 6 };
    yield return new List<int> { 7, 8, 9 };
  }

  static IEnumerable<int> Flatten()
  {
    foreach (var list in ListOfLists())
    {
      foreach (var item in list)
      {
        yield return item; // Returns each item one by one
        // Execution pauses here until the next iteration
      }
    }
  }
  static IEnumerable<int> RandomNumbers()
  {
    Random random = new Random();
    while (true)
    {
      yield return random.Next(1, 101);
    }
  }
  static void Main(string[] args)
  {
    Console.WriteLine("Flattened List:");
    foreach (var number in Flatten())
    {
      Console.Write(number + " ");
    }
    Console.WriteLine("\n");

    Console.WriteLine("Random Numbers:");
    foreach (var number in RandomNumbers().Take(10)) // Take first 10 random numbers
    {
      Console.Write(number + " ");
    }

  }

}