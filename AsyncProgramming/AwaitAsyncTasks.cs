using System;

class Program
{

  class Example3
  {
    async Task LongRunningJobAsync()
    {
      //Long running proccess
    }
    async Task Main()
    {
      // Calling LongRunningJobAsync()
      Task JobTask = LongRunningJobAsync(); // will not block the execution of the Main method.
      await JobTask; // Wait for the long running job to finish.
    }

    async Task<string>
    LongRunningJobWithReturnValue()
    {
      string result;
      // long running proccess to set result
      return result;
    }
    async Task Main()
    {
      // callling LongRunningJobWithReturnValueAsync() 
      Task JobTask = LongRunningJobWithReturnValueAsync();
      string value = await JobTask;
    }
  }

  static public async Task<string> ReturnGreetingAsync()
  {
    await Task.Delay(1000); // Simulate a delay.
   return "Hello, World!";
  }
  static async Task Main(string[] args)
  {
    Task<string> GreetingTask = ReturnGreetingAsync();
    Console.WriteLine("Waiting...");
    string greeting = await GreetingTask;
    Console.WriteLine(greeting);
}
}