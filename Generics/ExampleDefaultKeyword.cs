using System;

public class EmployeeData<T>
{
  public T? GetEmployeeData()
  {
    T? value = default(T);
    return default(T);
  }
}

class Program
{
  static void Main()
  {
    EmployeeData<int> myData = new EmployeeData<int>();

    int i = myData.GetEmployeeData();

    Console.WriteLine("i = {0}",i);
  }
}