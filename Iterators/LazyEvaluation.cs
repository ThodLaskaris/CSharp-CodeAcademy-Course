using System;

class Program
{

  public static IEnumerable<int> GetPrimes()
  {
    //  Infinite sequence of prime numbers.

    for (int number = 2; ; number++)
    {
      if (IsPrime(number))
      {
        yield return number;
      }

      /* main method example:
    IEnumerable<int> primes = GetPrimes();
    int count = 0;

    foreach (int prime in primes)
    {
      Console.WriteLine(prime);
      count++;
      if (countt == 5)
      {
        break;
      }
      */
    }
  }


  public static IEnumerable<string> GenerateLargeDataset(int count)
  {
    for (int i = 0; i < count; i++)
    {
      yield return $"Page {i + 1}"; // Returns each item one by one
      // Execution pauses here until the next iteration
    }
  }
  public static void Main(string[] args)
  {
    var largeDataSet = GenerateLargeDataset(1000000);
    int count = 1;
    foreach (var item in largeDataSet)
    {
      Console.WriteLine(item);
      count++;
      if (count > 10)
      {
        break;
      }
    }
  }
}
