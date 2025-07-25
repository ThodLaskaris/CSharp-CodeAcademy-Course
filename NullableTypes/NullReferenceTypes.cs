#nullable enable

using System;
using System.Collections.Generic;

namespace NullValues
{
  public class Program
  {
    public static string? ApiRequest()
    {
      Random random = new Random();
      if (random.Next(0, 2) == 0)
      {
        return null;
      }
      return "Success";
    }

    public static void Main()
    {
      string result = ApiRequest();

      if(result == null) {
        Console.WriteLine("The request failed");
      } else {
      Console.WriteLine("The length of the response is "+ result.Length);
      }

    }
  }
}