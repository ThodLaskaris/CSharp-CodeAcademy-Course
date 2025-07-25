using System;

class Program
{
  public class InvalidPasswordException : Exception
  {
    public InvalidPasswordException(string message) : base(message)
    {

    }
    public static void ValidatePassword(string password)
    {
      if (password.Length < 8)
      {
        throw new InvalidPasswordException("Password must be at least 8 characters long");
      }
    }
  }
  static void Main(string[] args)
  {
    try
    {
      InvalidPasswordException.ValidatePassword("123");
    }
    catch (InvalidPasswordException ex)
    {
      Console.WriteLine($"An exception has been thrown {ex.Message}");
    }
  }
}