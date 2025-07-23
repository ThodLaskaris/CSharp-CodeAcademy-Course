using System;

class Program
{

  public enum ProjectPriority
  {
    Low,
    Medium,
    High,
    Critical
  }
  public enum PriorityLevel
  {
    Low = 1,
    Medium = 2,
    High = 3,
    Critical = 4
  }

  [Flags]
  enum ProjectStatus
  {
    None = 0,
    NotStarted = 1,
    InProgress = 2,
    OnHold = 4,
    Completed = 8,
  }
  static void Main(string[] args)
  {
    /////////// Enum Example ///////////
    ProjectStatus currentStatus = ProjectStatus.InProgress | ProjectStatus.OnHold;
    Console.WriteLine($"Current Project Status: {currentStatus}");
    bool isOnHold = (currentStatus & ProjectStatus.OnHold) == ProjectStatus.OnHold;
    // Removing the onHold Status flag.
    currentStatus &= ~ProjectStatus.OnHold;
    Console.WriteLine($"Is project on hold? {isOnHold}");





    //////
    string[] priorities = Enum.GetNames(typeof(ProjectPriority));
    foreach (var priority in priorities)
    {
      Console.WriteLine(priority);
    }
    int[] priorityValues = (int[])Enum.GetValues(typeof(PriorityLevel));
    foreach (var priorityValue in priorityValues)
    {
      Console.WriteLine(priorityValue);
    }


    ParsePriority("Medium");
    ParsePriority("Low");
    ParsePriority("InvalidPriority");


  
  }
  public static void ParsePriority(string priority)
  {
    ProjectPriority parsedPriority = (ProjectPriority)Enum.Parse(typeof(ProjectPriority), priority);
    Console.WriteLine(priority);
  }
  public static ConvertPriority(string priority)
  {
    bool isParsed = Enum.TryParse<ProjectPriority>(priority, out ProjectPriority parsedPriority);


    if (isParsed)
    {
      Console.WriteLine($"Parsed priority: {parsedPriority}");
    }
    else
    {
      Console.WriteLine($"Invalid Priority value: {priority}");
    }
  }
}