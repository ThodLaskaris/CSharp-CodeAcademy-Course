/*
FileStream have property posistion
  - The position is the current location in the file where the next read or write operation will occur.
  - The position can be set using the Position property, which is of type long.
  - The position can be moved using the Seek method, which takes an offset and a SeekOrigin value.
  - The position can be reset to the beginning of the file using the SetLength method with a length of 0.


    Use Seek() to move the posisition to a specifig location in the file 
    Seek take two arguments. offsest and SEekOrigin value 

    offset: the number of bytes to move from the specified position.
    SeekOrigin: specifies the reference point for the offset. It can be one of the following

    SeekOrigin.End to move the position to the end of the file.`
    fs.Seek(0, SeekOrigin.End) to move the position to the end of the file.

    SeekOrigin.Current to move the position relative to the current position.
    fs.Seek(10(positions) SeekOrigin.Current) to move the position 10 bytes forward from the current position.

*/




using System;

class Program
{

  public static void Reset(FileStream fileStream)
  {
    fileStream.Seek(0, SeekOrigin.Beginh); // Move the position to the beginning of the file.
  }
  public static void MoveToMiddle(FileStream fileStream)
  {
    long length = fileStream.Length;  // Get the length of the file.
    long middle = length / 2;
    fileStream.Seek(middle, SeekOrigin.Begin);
  }
  public static void DoubleLength(FileStream fileStream)
  {
    long doubleLength = fileStream.Length * 2;
    fileStream.SetLength(doubleLength);
  }

  static void Main(string[] args)
  {
    // Your code here
    Console.WriteLine("Hello World");
  }
}