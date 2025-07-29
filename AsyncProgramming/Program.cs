using System;

class Program
{

  internal class Example3
  {
    //   TAP Method - Tasked based asychronous programming.
    async Task LongRunningJobAsync()
    {
      // Long running proccess
    }
    async Task Main()
    {
      //   Calling LongRunningJobAsync() will not block the execution of the Main method.
      Task JobTask = LongRunningJobAsync();
      await JobTask; // Wait for the long running job to finish.
    }
  }

  class Example1
  {


    void LongRunningAPICall()
    {
      //  Here is a API call that may take several minutes to complete.
    }
    // This is a sychronous method that blocks execution.
    void CallAPI()
    {
      LongRunningAPICall();
    }
    // This is a asychronous methot that doesnt block execution.
    async Task CallAPIAsync()
    {
      LongRunningAPICall();
    }
    async Task Main()
    {
      // Execute sychronous method , execution stops for several minutes while LongRunningAPICall() executes.
      CallAPI();
      Console.WriteLine("Enter your user id:");
      string Input1 = Console.ReadLine();
      // execute asychronous method, execution continues immediately while LongRunningAPICall() executes in the background.
      Task APITask = CallAPIAsync();
      // user is asked for input immediately.
      Console.WriteLine("Enter your user id:");
      string Input2 = Console.ReadLine();
      // Wait for API call to finish here.
      await APITask;
    }
    static void Main(string[] args)
    {
      // Your code here
      Console.WriteLine("Hello World");
    }
  }

  static public async Task PrintGreetingAsync()
  {
    await Task.Delay(1000);
    Console.WriteLine("Hello, World!");
}
  class Example2
  {
    public async Task PrintGreetingAsync()
    {
      await Task.Delay(1000);
      Console.WriteLine("Hello, World!");

    }
    public void Main()
    {
      Task myTask = PrintGreetingAsync();
      Console.WriteLine("Finished.");
    }
  }
}