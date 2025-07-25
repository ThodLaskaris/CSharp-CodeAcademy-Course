using System;
/// <summary>
/// Documention
/// </summary>
/// <param name="param1"> ,adasd</
class Program
{

  public static string ApiRequest()
  {
    Random random = new Random();
    if (random.Next(0, 2) == 0)
    {
      return null;
    }
    else
    {
      return "Success";
    }

  }

  public class Student
  {
    public string Name { get; set; }
    public int? Age { get; set; }
    public decimal? GPA { get; set; }

  }
  public static void Main(string[] args)
  {
    // for (int i = 0; i < 10; i++)
    // {
    //   string response = ApiRequest();
    //   Console.WriteLine($"Received response {response}");
    //   Console.WriteLine($"Response length {response.Length}");

    Student student = new()
    {
      Name = "Alice",
      Age = 20
    };
    Console.WriteLine($"{student.Name} was successfully Registered.\n{student.Age} was successfully registed.");

    Student noAgeStudent = new();
    noAgeStudent.Name = "Bob";
    noAgeStudent = null;

    noAgeStudent.GPA = 3.5m;

    Console.WriteLine($"{noAgeStudent.Name} was successfuly Registered");

    Student noGPA = new();
    noGPA.Name = "Charile";
    noGPA.Age = 20;
      noGPA.Age = null;
    console.WriteLine($"{noGPA.Name} was successfully registed");
  }

}

