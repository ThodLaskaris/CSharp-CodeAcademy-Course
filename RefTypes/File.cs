class File
{
  public string FileName { get; set; }
  public int FileSize { get; set; }
  public File(string fileName, int fileSize)
  {
    FileName = fileName;
    FileSize = fileSize;
  }
  public File()
  {
    FileName = string.Empty; // Default value for FileName
    FileSize = 0; // Default value for FileSize
  }
}