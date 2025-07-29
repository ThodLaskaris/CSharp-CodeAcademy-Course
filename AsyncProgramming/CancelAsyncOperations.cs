using System;

class Program
{
  class Example1
  {
    public Task CallAPISync(CancellationToken cancellationToken)
    {
      // ....
      // Do Work,
      // Check for cancellation request and exist immediately if there is one.

      if (cancellationToken.IsCancellationRequested)
      {
        // do cleanup work here..

        //throw the OperationCanceledException
        cancellationToken.ThrowIfCancellationRequested();
      }


      // Do more work...
    }


  }
  // static void Main(string[] args)
  // {
  //   CancellationTokenSource tokenSource = new CancellationTokenSource();

  //   Task callAPITask = CallAPISync(tokenSource.Token);
  // }

  public static async Task CountDownAsync()
  {
    if (cancellationToken.IsCancellationRequested)
    {
       cancellationToken.ThrowIfCancellationRequested();
    }
    for (int i = 5; i > 0; i--)
    {
      Console.WriteLine(i);
      await Task.Delay(100);
    }
  }
  static async Task Main()
  {
    Task count = CountDownAsync();
    CancellationTokenSource tokensource = new CancellationTokenSource();
    try
    {
      await count;
      Console.WriteLine("Countdown Complete!");
    }
    catch (OperationCanceledException e)
    {
      Console.WriteLine("Countdown Cancelled.");
    }
  }
}