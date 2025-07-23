using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
  public static List<T> ReturnCollection<T>(T value) {
    List<T> result = new List<T>();

    for (int i = 0; i < 10; i++) {
      result.Add(value);
    }
    return result;
  }
  


  static void Main()
  {
List<int> myIntList = ReturnCollection(15);
  }
}
