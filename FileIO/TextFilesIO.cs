using System;

/*
StreamReader methods.

- Read a single character.
char c = (char)sr.Read();

- Read the next line.
string line = sr.ReadLine();

-Read the rest of the file.
string content = sr.ReadToEnd();

*/
class Program
{


  public static string ReadFirstLine(string filename)
  {
    return "";
  }

  public static void WriteLines(string filename, string[] lines)
  {
    using (FileStream fs = new StreamReader(filename, Encoding.UTF8))
    {
      
    }
  }
  static void Main(string[] args)
  {





    // using (FileStream fs = new FileStream("file.txt", FileMode.Open, FileAccess.Read))
    // {
    //   // The StreamREader will read the fiel from the fs FileStream using the UTF8 endcoding.

    //   using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
    //   {
    //     string line;
    //     while ((line = sr.ReadLine()) != null)
    //     {
    //       Console.WriteLine(line); // Print each line to the console.

    //     }

    //     using (FileStream fs = new FileStream("output.txt", FileMode.Create, FileAccess.Write))
    //     {
    //       // The StreamWriter will write to the fs FileStream using the UTF8 encoding.

    //       using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
    //       {
    //         // Write a character.
    //         sw.Write('H');

    //         // Write a line
    //         sw.WriteLine("Ela man mou kalimera.");
    //       }
    //     }
    //   }
    // }
  }
}
