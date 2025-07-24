using System;

class Program
{
  // UnionWith = add ements from another collection to the current HashSet.
  // IntersectWith = keep only elements that are preset in both collections ( duplicates )
  // ExceptWith = remove elements from the current HashSet that are also in another collection.

  class example1
  {
    public List<int> numberList = new List<int> { 3, 4, 5, 6, 7 };
    public HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
    public HashSet<int> set2 = new HashSet<int>(numberList);
  }
  class example2
  {
    public static HashSet<T> UnionList<T>(List<T> list1, List<T> list2)
    {
      // Create a new HashSet to hold the union of the two lists
      HashSet<T> resultSet = new(list1);
      // Add elements from the second list to the HasSet using UnionWith.
      resultSet.UnionWith(list2);
      return resultSet;
    }
    public static HashSet<T> IntersectionList<T>(List<T> list1, List<T> list2)
    {
      // Create new HashSet to Hold the intersection of two lists. ( duplicate elemetns )
      HashSet<T> resultSet = new(list1);
      // Keep only emenets that are present in both lists using IntersectWith.
      resultSet.IntersectWith(list2);
      return resultSet;
    }
  }
  static void Main(string[] args)
  {

    example1 ex1 = new();

    ex1.set1.UnionWith(ex1.set2);
    Console.WriteLine("After UnionWith: " + string.Join(", ", ex1.set1));

    ex1.set1.IntersectWith(ex1.set2);
    Console.WriteLine("After IntersectWith: " + string.Join(", ", ex1.set1));

    ex1.set1.ExceptWith(ex1.set2);
    Console.WriteLine("After ExceptWith: " + string.Join(", ", ex1.set1));
  }

}
