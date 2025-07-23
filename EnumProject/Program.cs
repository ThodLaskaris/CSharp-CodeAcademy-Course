/*Transform the expense approval process as part of the Finance Technology team! 
Build a digital tracking system using C# enums to categorize, validate, and streamline submissions from draft to approval, redefining corporate expense management.
Code review available when you’re done
*/
using System;

class Program
{
  [Flags]
  public enum ExpenseType
  {
    None = 0,

    Travel = 1,
    Meals = 2,
    OfficeSupplies = 4,
    Software = 8,
    Entertainment = 16
  }
  static void Main(string[] args)
  {
    // Printing all the Expesne Types.
    foreach (ExpenseType type in Enum.GetValues(typeof(ExpenseType)))
    {
      if (type != ExpenseType.None)
      {
        Console.WriteLine($"Expense Type: {type}");
      }
    }

    ExpenseType expenses = ExpenseType.Travel | ExpenseType.Meals;
    Console.WriteLine($"\nCombined Expenses: {expenses}");

    if ((expenses & ExpenseType.Travel) == ExpenseType.Travel)
    {
      Console.WriteLine($"Travel expesnes are included.");
    }
    else
    {
      Console.WriteLine("Travel expenses are not included.");
    }
    Console.WriteLine(expenses);
    expenses &= ~ExpenseType.Meals;
    Console.WriteLine(expenses);

    // Parse a string to enum.

    string passingExpense = "Travel|Software";
    if (Enum.TryParse<ExpenseType>(passingExpense, ignoreCase: true, out ExpenseType parsedExpense))
    {
      Console.WriteLine($"Parsed Expense Type: {parsedExpense}");

    }
    else
    {
      Console.WriteLine("Invalid expesne type string.");
    }

  }
}