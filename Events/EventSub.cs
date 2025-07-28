using System;

class Program
{

  public class MessagePublisher
  {
    public delegate void MessageHandler(string message);
    public event MessageHandler MessageEvent;

    public void OnMessage(string message)
    {
      MessageEvent?.Invoke(message);
    }
  }

  public class MessageSubscriber
  {
    private readonly MessagePublisher _publisher;
    public MessageSubscriber(MessagePublisher publisher)
    {
      _publisher = publisher;
      _publisher.MessageEvent += OnEventPublished; // Sub
    }

    public void Unsubscribe()
    {
      _publisher.MessageEvent -= OnEventPublished; // Unsub.
      Console.WriteLine("Unsubscribed from MessageEvent");
    }

    public void OnEventPublished(string message) 
    {
      Console.WriteLine($"Message received: {message}");
    }
  }
    static void Main(string[] args)
  {

  }
}