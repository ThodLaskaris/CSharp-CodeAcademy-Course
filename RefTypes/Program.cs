using System;
/*
*
* Escape Room Adventure CodeAcademy
*
*/
class Program
{
  static void Main(string[] args)
  {
    FieldAgent agent1 = new("Agent Smith", 007);
    FieldAgent agent2 = agent1;
    agent2.SecretCode = 700;
    Console.WriteLine($"Agent1 SecretCode is {agent1.SecretCode}\nAgent2 SecretCode is {agent2.SecretCode}\n");

    File file1 = new("Confidential.txt", 1024);
    File file2 = new("Confidential.txt", 1024);
    bool sameFile = file1 == file2;
    Console.WriteLine($"is file1 and fil2 the same.? {sameFile}");

    Server mainServer = new("Active");
    Server backUpServer = new("Inactive");

    ISystem[] systems = new ISystem[] { mainServer, backUpServer };
    foreach (var system in systems)
    {
      system.Operate();
    }
  }
}