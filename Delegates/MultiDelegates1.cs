using System;

class Program
{
  public static void ToUpper(string text)
  {
    Console.WriteLine(text.ToUpper());
  }
  public static void Reverse(string text)
  {
    char[] charArray = text.ToCharArray();
    Array.Reverse(charArray);
    Console.WriteLine(new string(charArray));
  }
  public void ToLower(string text)
  {
    Console.WriteLine(text.ToLower());
  }
  static void Main(string[] args)
  {
    // Your code here
    Console.WriteLine("Hello World");
    Action<string> transform = ToUpper;
    transform("hello");
    transform += Reverse;
    transform("world");
    transform -= ToUpper;
    transform += ToLower;
    transform("hello World again");
  }
}