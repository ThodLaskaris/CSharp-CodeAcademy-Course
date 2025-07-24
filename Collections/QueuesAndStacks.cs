using System;

class Program
{

  // Queues and Stacks 
  //  Queue<T> is FIFO 
  //  Stack<T> is LIFO

  // Stack<T>.Push() add an item to the top of the stack.
  // Stack<T>.Pop() removes the item at the top of the stack.

  // Queue<T>.Enqueue() adds an item to the end of the queue.
  // Queue<T>.Dequeue() removes the item at the front of the queue.
  // Queue<T>.Peek() returns the item at the front of the queue without removing it.
  // Queue<T>.Count returns the number of items in the queue.
  // Queue<T>.Clear() removes all items from the queue.
  // Queue<T>.Contains() checks if an item is in the queue.

  // Both have metgods like isEmpty to see if is empty.
  // And Clear to remove all items
  class Example1
  {
    public static int RemoveUntil(Queue<int> queue, int element)
    {
      // Remove elemetns from the queue until the element is found.
      int removedCount = 0;
      while (queue.Count > 0 && queue.Peek() != element)
      {
        queue.Dequeue();
        removedCount++;
      }
      return removedCount;
    }

    public static bool PopIf(Stack<int> stack, int element)
    {
      // Pop(remove) the element from the stack if its on top.
      if (stack.Count > 0 && stack.Peek() == element)
      {
        stack.Pop();
        return true;
      }
      return false;
    }
  }
  class QueuesAndStacks
  {
    static void Main(string[] args)
    {
      // Your code here
      Console.WriteLine("Hello World");
    }

  }
}