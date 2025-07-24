using System;

using System.Collections.Generic;

//   List<T> is a generic collection that can hold any type T


class Program
{

  public static void AddToFrontAndBack<T>(LinkedList<T> linkedList, T value)
  {
    linkedList.AddFirst(value);
    linkedList.AddLast(value);
  }

  public static (T, T) RemoveFromFrontAndBack<T>(LinkedList<T> linkedList)
  {
    if (linkedList.Count == 0)
    {
      return (default(T), default(T));
    }
    else if (linkedList == 1)
    {
      T value = linkedList.First.Value;
      linkedList.Clear();
      return (value, value);
    }
    else
    {
      T first = linkedList.First.Value;
      T last = linkedList.Last.Value;
      linkedList.RemoveFirst();
      linkedList.RemoveLast();
      return (first, last);
    }
  }
  public static void PrintLinkedList<T>(LinkedList<T> linkedList)
  {
    Console.WriteLine(string.Join(" <-> ", linkedList));

  }
  public static void Main(string[] args)
  {
    Console.WriteLine("LinkedList Exercise");
    LinkedList<string> linkedList = new LinkedList<string>();
    linkedList.AddLast("B");
    linkedList.AddLast("C");
    Console.WriteLine("Initial LinkedList:");
    PrintLinkedList(linkedList);


    // Test AddToFrontAndBack

    AddToFrontAndBack(linkedList, "A");
    Console.WriteLine("\nAfter AddToFrontAndBack('A'):");
    PrintLinkedList(linkedList);

    // Test RemoveFromFrontAndBack
    var (first, last) = RemoveFromFrontAndBack(linkedList);
    Console.WriteLine($"\nRemoved from front: {first},Removed from the back : {last}");
    Console.WriteLine("After RemoveFromFrontAndBack");
    PrintLinkedList(linkedList);

    // Test edge cases
    linkedList<string> emptyList = new LinkedList<string>();
    var (emptyFirst, emptyLast) = RemoveFromFrontAndBack(emptyList);
    Console.WriteLine($"\nRemoved from empty list - front: {emptyFirst}, back: {emptyLast}");

    linkedList<string> singleElementList = new LinkedList<string>();
    singleElementList.AddLast("Single");
    var (singleFirst, singleLast) = RemoveFromFrontAndBack(singleElementList);
    Console.WriteLine($"\nRemoved from single element list - front: {singleFirst}, back: {singleLast}");
    Console.WriteLine("After RemoveFromFrontAndBack on single element list:");
    PrintLinkedList(singleElementList);
  }
}
