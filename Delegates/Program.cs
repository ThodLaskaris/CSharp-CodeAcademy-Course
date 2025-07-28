using System;

class Program
{
  public static int Add(int a, int b)
  {
    return a + b;
  }
  public static int Subtract(int a, int b)
  {
    return a - b;
  }

  public delegate int CalculatorOperation(int x, int y);


  // Delegates using Built-in Func<T, TResult> delegate. Generics
  // Func<string, string> TextProcessor = (text) => text.ToUpper();

  /*
Func: This is the most widely applicable and can be used as any delegate. It allows for the specification of parameter and return types.
Action: This represents delegates that have a void return type.
Predicate: This represents delegates that check a condition and return a bool. It will be covered in detail later in this lesson.
  */
  static void Main(string[] args)
  {
    // Using the delegate func<T>

    Func<int, int, int> addOperation = Add;

    Console.WriteLine(addOperation(5, 3));

    Action<double> printResult = Display;
    printResult(5.0);

    // CalculatorOperation addOperation = Add;
    // CalculatorOperation substractOperation = Subtract;
    // int result;
    // result = addOperation(5, 3);
    // Console.WriteLine(result);
  }
}