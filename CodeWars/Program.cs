using System;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;

class Program
{

  public class Animal
  {


    public int Age;
    public int Legs;
    public string Name;
    public string Species;
    public string Status;

    public Animal(string name, int age, int legs, string species, string status)
    {
      Name = name;
      Age = age;
      Legs = legs;
      Species = species;
      Status = status;
    }

    public virtual string Introduce()
    {
      return $"Hello, my name is {Name}, and I am {Age} years old.";
    }
  }

  public class Shark : Animal
  {
    public Shark(string name, int age, string status) : base(name, age, 0, "shark", status)
    {
    }
  }
  public class Cat : Animal
  {
    public Cat(string name, int age, string status) : base(name, age, 4, "cat", status)
    {

    }
    public override string Introduce()
    {
      return $"Hello, my name is {Name}, and I am {Age} years old.  Meow meow!";
    }
  }

  public class Dog : Animal
  {
    public string Master;
    public Dog(string name, int age, string status, string master) : base(name, age, 4, "dog", status)
    {
      Master = master;
    }
    public override string Introduce()
    {
      return base.Introduce();
    }
    public string GreetMaster()
    {
      return $"Hello {Master}";
    }
  }

  static void Main(string[] args)
  {
    // Your code here
    Console.WriteLine("Hello World");
  }
}
