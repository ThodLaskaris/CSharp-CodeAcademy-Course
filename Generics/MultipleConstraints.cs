using System;

class EmployeeData<T> where T : struct, IEquatable<T>, IComparable<T>
{
  T? data;
  public T? GetData() { return data; }
  public void SetData(T input) { data = input; }
  public int CompareData(T value)
  {
    IComparable<T>? idata = data; 
    int result = idata.CompareTo(value);
    return result;
  }
}

class Program
{
  static void Main()
  {

  }
}