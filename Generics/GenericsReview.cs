using System;
using System.Collections.Generic;

// Generic interface
public interface IContainer<T>
{
    void Add(T item);
    T? GetFirst();
}

// Generic class implementing generic interface
public class Container<T> : IContainer<T> where T : class
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public T? GetFirst()
    {
        return items.Count > 0 ? items[0] : null;
    }

    // Generic method
    public void PrintAll()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
  static void Main(string[] args)
  {
    // Example usage of the generic container
    Container<string> stringContainer = new Container<string>();

    stringContainer.Add("Hello, Generics!");

    Console.WriteLine("First item:");
    Console.WriteLine(stringContainer.GetFirst());

    Console.WriteLine("\nAll items:");
    stringContainer.PrintAll();
  }
}


