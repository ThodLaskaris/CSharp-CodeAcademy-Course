using System;

public class Example3
{
  public static string Position(char alphabet)
  {
    char[] alphabetArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

    int position = Array.IndexOf(alphabetArray, char.ToLower(alphabet)) + 1;

    return $"Position of alphabet: {position}";
  }

  public static string PositionWithAscii(char alphabet)
  {
    int position = alphabet - 'a' + 1; // ASCII arithmetic
    return $"Position of alphabet: {position}";
    /*
    ώρα η συνάρτηση κάνει αυτό:

position = alphabet - 'a' + 1
Για 'c':

position = 'c' - 'a' + 1
         = 99 - 97 + 1
         = 3
    */
  }
}