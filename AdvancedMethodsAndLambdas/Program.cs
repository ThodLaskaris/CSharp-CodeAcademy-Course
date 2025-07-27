using System;
/*
In this app we learn about Method Chaining.
.

*/
class Program
{

  public class Task
  {
    public string Title { get; set; }
    public string Priority { get; set; }
    public bool Active { get; set; }
    public bool Urgent { get; set; } = false; // DEfaults to false.

  }

  public class ProjectList
  {
    public List<Task> _tasks = new()
    {
   new Task { Title = "Update documentation", Priority = "Low", Active = false },
      new Task { Title = "Fix critical bug", Priority = "High", Active = true },
      new Task { Title = "Plan next sprint", Priority = "Medium", Active = true },
      new Task { Title = "Archive old files", Priority = "Low", Active = false },
      new Task { Title = "Review pull requests", Priority = "High", Active = true }

    };

    public List<Task> GetTasks()
    {
      return _tasks;

    }
    public void DisplayTasks()
    {
      _tasks.forEach(t => Console.WriteLine($"{t.Title} - Priority: {t.Priority}, Active: {t.Active}, Urgent: {t.Urgent}\n"));
    }
    public ProjectList SortByPriority()
    {
      _tasks = _tasks.OrderByDescending(t => t.Priority)
      .ToList();
      return this;
    }
    public ProjectList FilterActive()
    {
      _tasks = _tasks.Where(t => t.Active && t.Priority == "High")
      .ToList();
      return this;
    }
  }
  static void Main(string[] args)
  {

    ProjectList tasks = new();
    ProjectList organizedTasks = tasks;
    ProjectList urgentTasks;

    organizedTasks
    .SortByPriority()
    .FilterActive()
    .DisplayTasks();

  }
}