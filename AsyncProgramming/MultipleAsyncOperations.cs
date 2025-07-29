using System;


// await Task.WhenAll() allows you to run multiple asynchronous tasks concurrently and wait for all of them to complete before proceeding.
// await Task.WhenAll(new Task[] { Task1Async(), Task2Async(), Task3Async() });
// await Task.WhenAny() allows you to run multiple asynchronous tasks concurrently and proceed as soon as the first one completes.
// await Task.WhenAny(Task1Async(), Task2Async(), Task3Async());
// Task Task1 = LongTaskAsync1();
// Task Task2 = LongTaskAsync2();
// Task Task3 = LongTaskAsync3();
// await Task.WhenAll(Task1, Task2, Task3); 

/*
await Task.WhenAny( new Task[] { Task1Async(), Task2Async(), Task3Async() } );
 -- do smt... --
 await Task1Async();
 await Task2Async();
*/
class Program
{
  public static async Task Task1Async()
  {
    await Task.Delay(750);
    Console.WriteLine("Task 1 Complete.");
  }
  public static async Task Task2Async()
  {
    await Task.Delay(1000);
    Console.WriteLine("Task 2 Complete.");
  }
  public static async Task Task3Async()
  {
    await Task.Delay(500);
    Console.WriteLine("Task 3 Complete.");
  }
  static async Task Main()
  {
    Task taskVar = Task1Async();
    Task taskVar2 = Task2Async();
    Task taskVar3 = Task3Async();
    //await Task.WhenAll(taskVar, taskVar2, taskVar3);
    await Task.WhenAny(new Task[] { taskVar, taskVar2, taskVar3 });
    // Alternatively, you can use Task.WhenAny to proceed as soon as the first task completes
    // await Task.WhenAny(taskVar, taskVar2, taskVar3);
    // Console.WriteLine("First task completed!");
    // await Task.WhenAll(taskVar, taskVar2, taskVar3); // Wait
    Console.WriteLine("Complete...");
  }
}