using System;

class Program
{

  class Example1
  {
    public class CoordinateArgs : EventArgs
    {
      public int X { get; set; }
      public int Y { get; set; }

      public CoordinateArgs(int x, int y)
      {
        X = x;
        Y = y;
      }

      public class GPSPublisher
      {
        //  The event uses the CoordinateArgs class to pass the information.
        public event EventHandler<CoordinateArgs> GPSEvent;
        public void OnGPSEvent(int x, int y)
        {
          GPSEvent?.Invoke(this, new CoordinateArgs(x, y));

        }
        public void HandleMyEvent(object sender, CoordinateArgs e)
        {
          Console.WriteLine($"Received coordinates: X={e.X}, Y={e.Y}");
        }
      }
    }
  }

  public class MessageEventArgs : EventArgs
  {
    public string Message { get; }
    public MessageEventArgs(string message)
    {
      Message = message;
    }
  }
  public class MessagePublisher
  {

    public event EventHandler<MessageEventArgs> MessageEvent;
    public void OnMessage(string message)
    {
      MessageEvent?.Invoke(this, new MessageEventArgs(message));
    }
  }
  public class MessageSubscriber
  {
    public void OnEventPublished(object sender, MessageEventArgs e)
    {
      Console.WriteLine($"Subscriber: Event triggered!\nReceived message: {e.Message}");
    }
  }
  static void Main(string[] args)
  {
    // Your code here
    Console.WriteLine("Hello World");
  }
}