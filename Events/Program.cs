using System;

class Program
{

  class RaisingEventExample
  {
    public delegate void LoginFailureHandler(int attempt);
    public event LoginFailureHandler LoginFailure;

    public void OnLoginFailure(int attempt)
    {

      // Check if the event has subscribers before invoking it
      if (LoginFailure != null)
      {
        LoginFailure?.Invoke(attempt);
      }
    }
  }


  public class LoginFailurePublisher
  {
    public delegate void LoginFailureHandler(int attempt);
    public event LoginFailureHandler LoginFailure;
    public void OnLoginFailure(int attempt)
    {
      LoginFailure?.Invoke(attempt);
    }

    public class MessagePublisher
    {
      public delegate void MessageHandler(string message);
      public event MessageHandler MessageEvent;

      public void OnMessage(string message)
      {
        MessageEvent?.Invoke(message);
      }
    }

  
    
  }
  static void Main(string[] args)
  {
    // Your code here
    Console.WriteLine("Hello World");
    var publisher = new MessagePublisher();
    System.Console.WriteLine("the publisher has been created.");
  }
}