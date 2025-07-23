using System;

public interface IDataStore<T>
{
T? GetData();
void SetData(T data);
}
public class EmployeeIntData : IDataStore<int>
{
  int value;
  public int GetData(){ return value; }
  public void SetData(int input) { value = input; }
}
public class EmployeeData<T> : IDataStore<T>

{
  T? value;
 public T? GetData() {
  return value;
  }
public void SetData(T data) {
  value = data;
}  
}

class Program
{
  static void Main()
  {
  }
}