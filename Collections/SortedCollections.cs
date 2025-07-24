using System;

class Program
{

  public class Example1
  {

    // SortedSet<T> is a collection that maintains elements in sorted order
    // SortedSet methods include sortedSet.Add, sertedSet.Remove, sortedSet.Contains,
    //  sortedSet.UnionWith, sortedSet.IntersectWith, sortedSet.ExceptWith, etc.
    // Sorted Combine method = UnionWith.
    public static SortedSet<T> CombineSets<T>(SortedSet<T> set1, SortedSet<T> set2)
    {
      SortedSet<T> resultSet = new(set1);
      resultSet.UnionWith(set2);
      return resultSet;
    }

    public static List<TValue> FirstValues<TKey, TValue>(SortedDictionary<TKey, TValue> dictionary, int n)
    {
      // Create a list to hold the first n values.
      List<TValue> values = new();
      // Iterate through the dictionary and add the first n values to the list.
      foreach (var kvp in dictionary)
      {
        if (values.Count < n)
        {
          values.Add(kvp.Value);
        }
        else
        {
          break;
        }

      }
      return values;
    }
  }
}