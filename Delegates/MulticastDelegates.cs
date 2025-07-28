using System;

class Program
{

  delegate void LogHandler(string message);

  void ConsoleLogger(string message)
  {
    ConsoleLogger.WriteLine($"Console: {message}");
  }

  void FileLogger(string message)
  {
    FileLogger.WriteAllText("log.txt", message);
  }

  delegate int MathOperation(int a, int b);

  int Add(int a, int b) => a + b;
  int Subtract(int a, int b) => a - b;

  static void Main(string[] args)
  {
    LogHandler logHandler = ConsoleLogger;
    logHandler += FileLogger;
    logHandler("Hello world");

    logHandler -= ConsoleLogger;
    logHandler?.Invoke("Hello again");

    MathOperation mathOperation = Add;
    mathOperation += Subtract;

    int result = mathOperation(5, 3);
    // Result is 2
    // Note that the return value of Add, which is 8 , is ignored.
  }
}