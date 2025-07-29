using System;

class Program
{

  public static void WriteTwoBytes(FileStream fileStream, byte byte1, byte byte2)
  {
    // Writes 2 values bytes at the current possiton of FileStream. 
    fileStream.WriteByte(byte1);
    fileStream.WriteByte(byte2);
    fileStream.Flush();
  }
  public static int SafeWriteBytes(string filename, byte[] buffer)
  {

    try
    {
      using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
      {
        fs.Write(buffer, 0, buffer.Length); // Writes the enire buffer to the file.
        return buffer.Length; // Returns the number of bytes written.
      }
    }
    catch (FileNotFoundException ex)
    {
      return -2; // File not found
    } catch( UnauthorizedAccessException ex)
    {
      return -1; // Access denied
    }

}

  static void Main(string[] args)
  {
    using (FileStream fs = new FileStream("test.txt", FileMode.Create, FileAccess.Write))
    {
      WriteTwoBytes(fs, 65, 66); // Writes the bytes 65 and 66 to the file.
    }
    byte[] dataToWrite = new byte[] { 67, 68, 69, 70 };
    int result = SafeWriteBytes("output.txt", dataToWrite);


    byte[] data = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

    using (FileStream fs = new FileStream("file.txt", FileMode.Create, FileAccess.Write))
    {
      fs.Write(data, 0, data.Length); // Write the entire data array to the file.

    }

    using (FileStream fs = new FileStream("file.txt", FileMode.Open, FileAccess.Write))
    {
      fs.WriteByte(9); // Write a single byte to the file.
      fs.Flush(); // Ensure the data is written to the file.
    }
  }
}