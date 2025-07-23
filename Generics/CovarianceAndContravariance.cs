using System;

interface ICovariant<out T>
{
  T? GetData();
}
interface IContravariant<in T>
{
  void SetData(T value);
}
class Employee 
{

}
class Manager : Employee
{

}
class EmployeeData<T> : ICovariant<T>, IContravariant<T>
{
  T? data;
  public T? GetData() { return data; }
  public void SetData(T input) { data = input; }
}

class Program
{
  static void Main()
  {
    ICovariant<Employee> Covariant = new EmployeeData<Manager>();
    IContravariant<Manager> Contravariant = new EmployeeData<Employee>();
  }
}