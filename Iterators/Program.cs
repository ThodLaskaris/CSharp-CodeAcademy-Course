using System;

/*

 - Yield keyword.
  - Yield returns an element to the caller and pauses the method's execution.
  - When the method is called again, it resumes from where it left off.


  -IEnumerable<T> is an interface that allows iteration over a collection.
  - It provides a way to access elements in a collection without exposing the underlying structure.


  -IEnumerator<T> is an interface that provides the ability to iterate over a collection.
  - It allows moving through the collection and accessing its elements one at a time.

  - Lazy Evaluation and deferred execution are concepts where the evaluation of an expression is delayed until its value is needed.
  - This can improve performance by avoiding unnecessary calculations and memory usage.

  - Custom Iterators allow you to define your own iteration logic for a collection.
  - They can be implemented using the yield keyword to return elements one at a time.

  - Advanced iterator patterns include techniques like filtering, transforming, and combining collections.
  - These patterns allow for more complex operations on collections while maintaining a clean and readable code structure

*/

class Program
{


  static void PrintElements<T>(List<T> items)
  {
    foreach (T item in items)
    {
      Console.WriteLine(item);

      /*
       Main method example:
          // List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
      // List<string> names = new List<string> { "DrSeal", "MentorSeal", "CSharpSeal", "DrSealSharp" };

      // PrintElements(numbers);
      // Console.WriteLine();
      // PrintElements(names);
      */
    }
  }



  public static void Main()
  {
    Console.WriteLine("Counting by twos: ");
    foreach (int number in CountByTwos(10))
    {
      Console.Write(number + " ");

    }
    Console.WriteLine("\n");

    Console.WriteLine("Repeating a word:");

    foreach (string word in RepeatWord("Hello", 5))
    {
      Console.WriteLine(word);
    }
  }

  public static IEnumerable<int> CountByTwos(int limit)
  {
    for (int i = 2; i <= limit; i += 2)
    {
      yield return i; // Returns the current value and pauses execution
    }
  }

  public static IEnumerable<string> RepeatWord(string word, int times)
  {
    for (int i = 1; i <= times; i++)
    {
      yield return $"{word} {i}";
    }
  }

  public static IEnumerable<char> GetCharacters(string input)
  {
    foreach (char character in input)
    {
      yield return character;
    }

  }
  public static IEnumerable<char> GetLetters(string input)
  {
    foreach (char character in input)
    {
      if (char.IsLetter(character))
      {
        yield return character;
      } 
      
    }
  }

  public static void Main(string[] args)
  {
    string input = "Hello,World!";
    Console.WriteLine("All characters");
    foreach (char character in GetCharacters(input))
    {
      Console.Write(character + " ");
    }
    Console.WriteLine("\n");

    Console.WriteLine("Letters only: ");
    foreach (char character in GetLetters(input))
    {
      Console.Write(character + " ");
    }
  }
















}


