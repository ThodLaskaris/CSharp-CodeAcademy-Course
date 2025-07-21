using System;

class Program
{
  static void Main(string[] args)
  {
    Employee hr = new HR();
    hr.Work();
    hr.SubmitDailyReport();
    hr.ClockIn();

    Console.WriteLine();
    Employee employee1 = new Engineer();
    employee1.SubmitDailyReport();

    Console.WriteLine();
    Employee employee2 = new Manager();
    Employee employee3 = new Intern();

    employee2.ClockIn();
    employee2.Work();
    employee2.SubmitDailyReport();

    Console.WriteLine();
    employee3.ClockIn();
    employee3.Work();
    employee3.SubmitDailyReport();

    Engineer? engineer1 = employee1 as Engineer;
    if (engineer1 != null)
    {
      engineer1.SubmitDailyReport();
    }
    else
    {
      System.Console.WriteLine("Downcast failed.");
    }

    List<Employee> employees = new()
    {
      employee1,
      employee2,
      employee3
    };

    foreach (var employee in employees)
    {

      if (employee is Engineer)
      {
        Console.WriteLine("This is an Engineer..\n");
      }
      else if (employee is Intern)
      {
        Console.WriteLine("This is an Intern..\n");
      }
      else if (employee is Manager)
      {
        Console.WriteLine("This is a Manager..\n");
      }
      employee.Work();
      employee.SubmitDailyReport();
      employee.ClockIn();
    }
    System.Console.WriteLine();
  }
}