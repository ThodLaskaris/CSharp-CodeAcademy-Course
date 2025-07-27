class ArrayMethods
{
  internal class Example1
  {
    int[] numbers = { 1, 3, 5, 6, 7, 8 };
    ///
    public static bool isEven(int num)
    {
      return num % 2 == 0;
    }
    bool hasEvenNumber = Array.Exists(numbers, isEven);
  }
  /*
  More array methods.
  Array.Find() Returns the first element that matches the condtion.
  Array.FindAll() Returns all elements that match the condition
  Array.FindIndex() Retunrs the index of the first element that matchtes the conditin.
  */

  public static bool IsLong(string word)
  {
    return word.Length > 8;

  }
  static void Main(string[] args)
  {
    //  Array to be used as first argument.
    string[] adjectives = { "rocky", "mountainous", "cosmic", "extraterrestrial" };
    //  Call Array.Find() and Pass in the array and method as arugments.
    string firstLongAdjective = "";
    firstLongAdjective = Array.Find(adjectives, IsLong);

    Console.WriteLine($"The first long word is: {firstLongAdjective}.");

  }
}