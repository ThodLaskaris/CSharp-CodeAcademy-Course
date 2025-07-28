using System;

class Program
{

  class Example1
  {
    public event EventHandler myEvent;
    public void OnMyEvent()
    {
      myEvent?.Invoke(this, EventArgs.Empty);
    }

    public class MySybscriber
    {
      public void HandleMyEvent(object sender, EventArgs e)
      {
        //  Respond to the event.
        // The simpliest way to use this pattern is by passign two arguments, the publisher class (this) 
        // and no information through EventArgs using the EventArgs.Empty
      }

      // Defind an event using the ProgressChangedEventArgs class with the publisher class.

      public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
      // Other common EventArgs classes include:
      // - MouseEventARgs - contains info about mouse events.
      // - KeyEventArgs - contains info about keyboard events.
      // - CancelEventArgs - Contains a Cancel prop that can be set to true to cancel an operation.
    }
  }


  public class ClosingPublisher
  {
    public event EventHandler Closing;
    public void OnClosing()
    {
      Closing?.Invoke(this, EventArgs.Empty);
    }
  }
  public class ClosingSubscriber
  {
    public void HandleClosing(object sender, EventArgs e)
    {
      // Respond to the closing event.
      System.Console.WriteLine("Market is closing");
    }
  }
  static void Main(string[] args)
  {
    var publisher = new ClosingPublisher();
    var subscriber = new ClosingSubscriber();

    publisher.Closing += subscriber.HandleClosing;
    publisher.OnClosing();

  }
}