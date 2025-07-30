/*
Cusotm iteratros.
This file contains implementations of custom iterators in C#.
Custom iterators allow you to define your own iteration logic for a collection, which can be more
Current()
This property returns the current element in the sequence.

MoveNext()
This method advnaces the iterator to the next element in the sequence. Return true if there is a next element false otherwise.

Reset()
Resets the iterator to its initial position which is before the first element in the sequence.

Dispose()
This method is optional and can be used to release - clean up any resources used by the iterator.

*/

using System;

class Program
{

  class Example1
  {
    class SaveFileReader : IEnumerator<string>
    {
      private StreamReader reader;
      private string currentLine;
      public int Current
      {
        get { return currentLine; }
      }
      object IEnumerator.Curent
      {
        get { return Current; }
      }
    }
    public SaveFileReader(string fileName)
    {
      reader = new StreamReader(fileName);
    }
    public bool MoveNext()
    {
      currentLine = reader.ReadLine();
      return currentLine != null;
    }
    public void Reset()
    {
      //  Resets the stream to the begining of the file.
      SaveFileReader.BaseStream.Seek(0, SeekOrigin.Begin);
    }
    public void Dispose()
    {
      reader.Close();
    }
    // static void Main(string[] args)
    // {
    //   string filePath = "savefile.txt";
    //   var saveFileReader = new SaveFileReader(filePath);
    //   foreach (var line in saveFileReader)
    //   {
    //     Console.WriteLine(line);
    //   }
    // }
  }
  public class RangeIterator : IEnumerator<int>
  {
    private int start;
    private int end;
    private int current;

    public RangeIterator(int start, int end)
    {
      this.start = start - 1;
      this.end = end;
      this.current = this.start;
    }
    public int Current
    {
      get { return current; }

    }
    object IEnumerator.Current
    {
      get { return Current; }
    }
    public bool MoveNext()
    {

      if (current < end)
      {
        current++;
        return true;
      }
      return false;
    }
    public void Reset()
    {
      current = start;
    }
    public void Dispose()
    {
      
    }

  }
  static void Main(string[] args)
  {
    using (var rangeIterator = new RangeIterator(1, 5))
    {
      while (rangeIterator.MoveNext())
      {
        Console.WriteLine(rangeIterator.Current);
      }
    }
  }
}