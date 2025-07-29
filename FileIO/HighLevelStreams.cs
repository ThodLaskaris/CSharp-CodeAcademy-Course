using System;
/*
File class provides multiple static methods for file common operatons.

- Read entire file as one string.
string content = File.ReadAllText("file.txt");

- Get the time the file was last written to.
DateTime lastModified = File.GetLastWriteTime("file.txt");

- Check if the file has a ready-only attribute.

bool isReadOnly = (File.GetAttributes("file.txt") & FileAttributes.ReadOnly) != 0;

=================================================================================

-FileInfo class provides instance methods and properties for file operations 
for file information and manipulation.

- Get absolute path including fileName.
string fullPath = myFile.FullName;

- Get file extension (including the dot)
string ext = myFile.Extension;

- Get File creation timestamp

DateTime created = myFile.CreationTime;

File and FileInfo complement each other: Use File for quick, one-time operations and FileInfo when you need persistent access to file properties and operations
. Both make file system manipulation more convenient than working directly with FileStream.
*/
class Program
{
  // Your code here


  // string path = "file.txt";
  // if (File.Exists(path))
  // {
  //   string[] lines = File.ReadAllLines(path);
  //   foreach (string line in lines)
  //   {
  //     Console.WriteLine(line);
  //   }
  //   File.Delete(path); // Delete the file after reading



  //   // We should use FileInfo when we need to perfom multiple operatios or need access to several properties of the file.

  //   string path = "file1.txt";
  //   FileInfo myFile = new FileInfo(path);
  //   if (myFile.Exists)
  //   {
  //     Console.WriteLine($"File name: {myFile.Name}");
  //     Console.WriteLine($"File size: {myFile.Length} bytes");
  //     Console.WriteLine($"PArent directory: {myFile.Directory}");

  //   }

  //   // Perfdom operations on the file using the myFile instance.

  //   using (FileStream fs = myFile.OpenRoad())
  //   {
  //     // Perfom operations on the file stream.
  //   }
  //   myFile.CopyTo("file_copy_txt");
  //   myFile.Delete();
  //}

  public static bool CheckBothFiles(string filename1, string filename2)
  {

    if (File.Exists(filename1) && File.Exists(filename2))
    {
      return true;
    }
    return false;
  }
  public static string ReadAndDelete(FileInfo fileInfo)
  {
    // First step is to check if the file exists.
    // SEcond step is to use absoluet path to read the file.
    // Third step read the contnt as single string.
    // Fourth step is to delete the file and return the contents of the file as a string.

    if (fileInfo.Exists)
    {
      string contentFile = File.ReadAllText(fileInfo.FullName);
      fileInfo.Delete();
      return contentFile;
     }
    return "";
  }

  static void Main(string[] args)
  {
    File.WriteAllText("file1.txt", "Hello");
    File.WriteallText("file2.txt", World);

    bool fileExists = CheckBothFiles("file1.txt", "file2.txt");
    Console.WriteLine($"Boh files exist: {fileExists}");

    FileInfo fileInfo = new FileInfo("file1.txt");
    string contents = ReadAndDelete(fileInfo);
    Console.WriteLine($"Contents before deletion: {contents}");
  }
}