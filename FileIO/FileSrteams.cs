/*
  FileStream fs = new FileStream("file.txt", FileMode.Open, FileAccess.Read);

  - FileMode.Create creats new file if the file already exists , getting overwritten
  - FileMode.CreateNew cerats a new file , if the file already exists it throws an exception.
  - FileMode.Open opens an exisistinf ile, if the file does not exist it throws an exception.
  - FileMode.OpenOrCreate opens a file if it exists, or creates a new file if it doesnt exist.
  - FileMode.Append opens a file if it wxists and moves the wriiting posistion so that any new data will be added to the end of the file.
    If the file does not exists, it creates a new file.
  - FileMode.Truncate opens an xisist file and empties it of any contecnt. If the file doesnt not exists, it throws an exception.

  =======================================================================================================================================
  - FileAccess.Read indicates the file can be only be read from.
  - FileAccess.Write indicates the file can only be written to.
  - FileAccess.ReadWrite indicates the file can be read from or written to.
  =======================================================================================================================================
  - FileShare.Read allows other process to read the file while it is open.
  Read takes 3 arguments: 
  A array of bytes to read into, the offset in the array at which to begin writing, and the number of bytes to read.
  - FileShare.Write allows other process to write to the file while it is open.

  If we want to read 1 byte at a time, we can use the ReadyByte method.

*/


using System;

class Program
{

  class Example1
  {
    
  }
  static void Main(string[] args)
  {
    try
    {
      using (FileStream fs = new FileStream("badfile.txt", FileMode.Open))
      {
        // the operatios might not be reached

      
      }
    }
    catch (FileNotFoundExcepetion ex)
    {
      Console.WriteLine("File not found: " + ex.Message);
    }
    catch (UnathorizedAccessException ex)
    {
      Console.WriteLine("Access denied :" + ex.Message);
    }

    using (FileStream fs = new FileStream("content.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
    {

    }

    using (FileStream fs = new FileStream("output.txt", FileMode.Create, FileAccess.Write))
    {

    }
  }
}