using System;
using System.Dynamic;

class Resource
{
  public string Title { get; private set; }
  public string Category { get; private set; }
  public string Status { get; protected set; }

  public Resource(string title, string category, string status = "Available")
  {
    Title = title;
    Category = category;
    Status = status;
  }

  public virtual void UpdateStatus()
  {
    if (Status == "Available")
    {
      Status = "Out";
    }
    else if (Status == "Out")
    {
      Status = "Available";
    }
    else
    {
      throw new Exception("Invalid status change.");
    }
  }

  public virtual void GetInfo()
  {
    Console.WriteLine($"Title: {Title}\nCategory: {Category}\nStatus: {Status}");
  }
}