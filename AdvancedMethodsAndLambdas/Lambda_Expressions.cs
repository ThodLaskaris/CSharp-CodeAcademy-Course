class LambdaExpressions
{
  internal class Example1
  {
    int[] numbers = { 1, 2, 3, 6, 8, 9 };
    public static bool IsEven(int num)
    {
      return num % 2 == 0;
    }
    // bool hasEvenNumber = Array.Exists(numbers, IsEven);
    bool hasEvenNumber = Array.Exists(numbers, (int num) => num % 2 == 0);
    // (input parameters) => expression;

    bool hasBigDozen = Array.Exists(numbers, (int num) =>
    {
      bool isDozenMultiple = num % 12 == 0;
      bool greaterThan20 = num > 20;
      return isDozenMultiple && greaterThan20;
    });
  }
}