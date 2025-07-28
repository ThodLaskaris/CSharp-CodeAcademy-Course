using System;

class Program
{
  static void Main(string[] args)
  {
    Func<int, int, int> calculatorOperation;
    calculatorOperation = (x, y) => x + y;
    Console.WriteLine(calculatorOperation(5, 3));

    calculatorOperation = (x, y) => x - y;
    Console.WriteLine(calculatorOperation(5, 3));
  }
}