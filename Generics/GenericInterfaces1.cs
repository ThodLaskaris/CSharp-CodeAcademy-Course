using System;

class EmployeeData<T> where T : IEquatable<T>
{
  T? data;
  public T? GetData() { return data; }
  public void SetData(T input) { data = input; }
  public bool DataMatch(T value)
  {
    bool result = data.Equals(value);
    return result;
  }
}

class Program
{
  static void Main()
  {

  }
}


/*
struct or class constraints must be the first constraint listed.
new() must be the last.
Only one base class constraint is allowed.
The struct and new() constraints can’t be combined.
class and struct constraints can’t be combined.
So, we can implement something like the following:

class myClass<T> where T : class, IComparable<T>, ISomeInterface, new() { } 
*/