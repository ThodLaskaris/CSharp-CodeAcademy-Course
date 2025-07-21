using System.Net.WebSockets;

abstract public class Employee
{
  public abstract void SubmitDailyReport();
  public virtual void Work()
  {
    Console.WriteLine("Employee is working..");
  }
  public void ClockIn()
  {
    Console.WriteLine("Employee clocked in.");
  }
}