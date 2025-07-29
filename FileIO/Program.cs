/*
-FileStream is used for reading and writing to files async.
-NetworkStream reads or writes over a network connection such as a TCP socket.
-CrpytoStream perfoms cryptographic operations such as  encyprition or decryption 
*/

using System;

class Program
{
  static void Main(string[] args)
  {
    string inputFilePath = "input.txt";
    string outputFilePath = "output.txt";

    try
    {
      if (File.Exists(inputFilePath))
      {
        long inputLength = new FileInfo(inputFilePath).Length;
        Console.WriteLine($"Length of 'input.txt': {inputLength} bytes");
      }
      else
      {
        Console.WriteLine($"File 'input.txt' does not exist.");
        return;
      }

      List<string> lines = new List<string>();
      using (StreamReader reader = new StreamReader(inputFilePath))
      {
        string line;
        Console.WriteLine("\nReading 'input.txt' line by line:\n");

        while ((line = reader.ReadLine()) != null)
        {
          Console.WriteLine($"Line: {line}");
          lines.Add(line);
        }
      }

      if (File.Exists(outputFilePath))
      {
        long outputLength = new FileInfo(outputFilePath).Length;
        Console.WriteLine($"\nLength of 'output.txt': {outputLength} bytes");
      }
      else
      {
        Console.WriteLine($"\nFile 'output.txt' does not exist. Creating new file.");
        File.Create(outputFilePath).Dispose();
      }

      using (StreamWriter writer = new StreamWriter(outputFilePath, true))
      {
        foreach (var line in lines)
        {
          writer.WriteLine(line);
        }
      }

      long finalOutputLength = new FileInfo(outputFilePath).Length;
      Console.WriteLine($"Final length of 'output.txt': {finalOutputLength} bytes");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"An error occurred: {ex.Message}");
    }
  }
}
