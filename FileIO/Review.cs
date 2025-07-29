using System;
using System.IO;
using System.Text;

namespace FileStreamReview
{
  class Program
  {
    static void Main(string[] args)
    {
      string filename = "review.txt";

      // 1. Basic FileStream - Write bytes
      using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
      {
        byte[] data = new byte[] { 72, 101, 108, 108, 111 }; // "Hello"
        fs.Write(data, 0, data.Length);
      }

      // 2. Basic FileStream - Read bytes
      using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
      {
        byte[] buffer = new byte[5];
        int bytesRead = fs.Read(buffer, 0, buffer.Length);
        Console.WriteLine($"Bytes read: {bytesRead}");
      }

      // 3. StreamWriter - Write text
      using (StreamWriter writer = new StreamWriter(filename))
      {
        writer.WriteLine("Line 1: Hello");
        writer.WriteLine("Line 2: World");
      }

      // 4. StreamReader - Read text
      using (StreamReader reader = new StreamReader(filename))
      {
        string allText = reader.ReadToEnd();
        Console.WriteLine($"Text read: {allText}");
      }

      // Clean up
      File.Delete(filename);
    }
  }
}