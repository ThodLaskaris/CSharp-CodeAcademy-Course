using System;
/*
Types of execptions.
- FomatException = If the user enters something thats not a number.
-DivideByZeroException = if the users enter zero as a divior.
-Exception = Exceptions general.
-NullReferenceException = if the user tries to access a null object.
-IndexOutOfRangeException = if the user tries to access an index of an array that does not exist.
-ArgumentException = if the user passes an argument that is not valid.
-FileNotFoundException = if the user tries to access a file that does not exist.
-InvalidOperationException = if the user tries to perfom an operation that is not valid for the current state of the object.
-OverflowException = if the user tries to perfom an operation that results in a overflow.
*/
class Program
{

  class Example1
  {
    int[] numbers = { 1, 2, 3, 4, 5 };
    int value = numbers[7]; // This will throw an IndexOutOfRangeException because the index[7] is not valid for the array.

  }
  class Example2
  {
    private string email;
    public void SetEmail(string email)
    {
      if (!email.Contains("@"))
      {
        throw new ArgumentException("Email must contain '@' character.");
      } // Otherwise put this email in email var.
      this.email = email;
    }
  }
  class Example3
  {

    public static string AccessArray(int[] numbers, int index)
    {
      try
      {
        Console.WriteLine($"Attempting to access element at index {index}.");
        int value = numbers[index];
        return $"Value at index {index} : {value}";

      }
      catch (IndexOutOfRangeException ex) when (numbers.Length == 0)
      {
        return $"Attempted to access an element in an empty array: {ex.Message}";
      }
      catch (IndexOutOfRangeException ex) // General case of IndexOutOfRangeException exception.
      {
        return $"Attempted to access an element outside the bounds of the array. Error: {ex.Message}";
      }

      catch (Exception ex)
      {
        return $"Caught exception: {ex.Message}";
      }
    }

  }
  static void Main(string[] args)
  {
    int[] numbers = { 2, 4, 6, 8, 10, 12 };
        Console.WriteLine(AccessArray(numbers,6));
  }
}