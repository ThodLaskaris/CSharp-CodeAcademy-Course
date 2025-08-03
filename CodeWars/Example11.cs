using System;


public class Greetings
{
  public static string Greet(string name)
  {
    if (string.IsNullOrEmpty(name))
    {
      return null;
    }
    return $"hello {name}!";
  }

 }
