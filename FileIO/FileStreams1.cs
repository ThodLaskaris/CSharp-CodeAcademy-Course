using System;

class Program
{

  public static int ReadTillZero(FileStream fileStream)
  {
    int bytesRead = 0;
    int currentByte;

    while ((currentByte = fileStream.ReadByte()) != -1)
    {
      if (currentByte == 0)
      {
        return bytesRead;
      }
      bytesRead++;
    }
    return -1;
  }
  public static int SaferFileBytes(string filename, byte[] buffer)
  {
    return 0;
  }

  static void Main(string[] args)
  {
    string filePath = "example.txt";

    //  Create a sample file with some data.
    File.WriteAllBytes(filePath, new byte[] { 68, 72, 48, 0, 52, 53 }); // Data: { 68, 72, 48, 0, 52, 53 }
    System.Console.WriteLine("Reading file until the first zero byte...");

    try
    {
      using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
      {
        int result = ReadTillZero(fileStream);
        if (result != -1)
        {
          Console.WriteLine($"Number of bytes until the first zero : {result}");
        }
        else
        {
          Console.WriteLine("No zero byte found in the file.");
        }
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"An error occured {ex.Message}");
    }
    finally
    {
      // Clean up 

      if (File.Exists(filePath))
      {
        File.Delete(filePath);
      }
    }
  }
}