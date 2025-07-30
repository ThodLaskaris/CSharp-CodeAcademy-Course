using System;

class Program
{
  public static IEnumerable<int> GetRandomNumbers()
  {
    Random random = new Random();
    for (int i = 0; i < 10; i++)
    {
      yield return random.Next(1, 100); // Returns a random number between 1 and 100
                                        // Execution pauses here until the next iteration
      
      /* main example:
    IEnumerable<int> randomNumbers = GetRandomNumbers();
    foreach (int number in randomNumbers)
    {
      Console.WriteLine(number);
    }
      */
    }
  }

  public class Name
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Name(string first, string last)
    {
      this.FirstName = first;
      this.LastName = last;
    }
  }

  public static List<Name> GatherData()
  {
    Name john = new Name("John", "Doe");
    Name monica = new Name("Monica", "Stravile");
    return new List<Name> { john, monica };
  }
  public static IEnumerable<string> GetFullNames(List<Name> people)
  {
    // Iterate over the data and combine the names
    // Return each name using yield.
    foreach (var person in people)
    {
      yield return $"{person.FirstName} {person.LastName} ";
    }
  }
  public static void DisplayFullNames(IEnumerable<string> names)
  {
    foreach (var name in names)
    {
      Console.WriteLine(name);
    }
  }

  static void Main(string[] args)
  {

  }
}