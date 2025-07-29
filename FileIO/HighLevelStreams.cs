using System;

class Program
{
  static void Main(string[] args)
  {
    // Your code here
    Console.WriteLine("Hello World");

    string path = "file.txt";
    if (File.Exists(path))
    {
      string[] lines = File.ReadAllLines(path);
      foreach (string line in lines)
      {
        Console.WriteLine(line);
      }
      File.Delete(path); // Delete the file after reading
    }
    }
}