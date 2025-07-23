using System;

class Program
{
  static void Main(string[] args)
  {
    // List<int> numbers = new();
    // List<string> strings = new();
    // List<boolean> bools = new();

    // Employees employee = new();
    // foreach (var employeeID in employee.EmployeeID)
    // {
    //   Console.WriteLine($"Employee ID: {employeeID}");
    // }

    Employees employee = new();
     List<int> IDs = employee.IDList();
      List<string> titles = employee.TitleList();

    for (int i = 0; i < IDs.Count; i++)
    {
 
      Console.WriteLine($"Employee ID: {IDs[i]}, Title: {titles[i]}");
    }

  }
}

