using System;

class Program
{
  static void Main(string[] args)
  {
    //  Star simulations

    Star sun = new("Sun", "G-Type");
    sun.Shine();
    sun.GrowOlder();
    sun.Shine();
    sun.Supernova();

    Star unknownStar = new("DrSeal# Star");
    unknownStar.Shine();
    unknownStar.GrowOlder();
  }
}
public class Star
{
  public string name;
  public string type;
  public int age;
  public double brightness;

  public Star(string name, string type)
  {
    this.name = name;
    this.type = type;
    this.age = 0;
    this.brightness = 1.0;
  }
  public Star(string name) : this(name, "Unknown")
  {
    Console.WriteLine("Star type set to default: Unknown");
  }

  public void Shine()
  {
     Console.WriteLine($"Star {name} is shining with brightness {brightness}");
  }
  public void GrowOlder()
  {
    age += 1000000000;
    brightness += 0.9;
  }
  public void Supernova()
  {
    brightness = 0;
    Console.WriteLine($"Star {name} has exploded in a Supernova.");
  }

}











// using System;


// class Program
// {
//   static void Main(string[] args)
//   {


































// //     var spaceInventory = new string[] {
// //        "Space Suits", "Oxygen Tanks", "Food Supplies", "Medical Kits", "Communication Devices" , "Fuel Canisters", "Navigation Tools", "Repair Tools"
// //     };
// //     var itemQuantities = new int[] {
// //       10,8,15,5,6,9,4,7
// //     };

// //     if (spaceInventory.Length == 8)
// //     {
// //       Console.WriteLine("Space Inventory is ready to go!");
// //     }
// //     else if (spaceInventory.Length > 8)
// //     {
// //       Console.WriteLine("Too many items!");
// //     }
// //     else
// //     {
// //       Console.WriteLine("Add more items!");
// //     }
// //     spaceInventory[8] = "Scientific Instruments";
// //     System.Console.WriteLine($"The second item of the array is {spaceInventory[1]} with {itemQuantities[1]}");
// //     itemQuantities[8] = 5;

// //     Array.IndexOf(itemQuantities, 3);
// //     Console.WriteLine($"The first item with quantity 5 is at position {itemQuantities[3 + 1]}");

// //     Array.Reverse(spaceInventory);
// //     Console.WriteLine($"The reversal was successfull\nThe last 2 items in the array are {spaceInventory[7]} and {spaceInventory[8]}");

// //     Array.Sort(spaceInventory);
// //     Console.WriteLine(spaceInventory.Length);
// //     Console.WriteLine($"{spaceInventory[0]} and {spaceInventory[8]}");












// //     // //Test Cases  

// //     // // Console.WriteLine(RectangleArea(4, 5));
// //     // // Console.WriteLine(CircleArea(4));
// //     // // Console.WriteLine(TriangleArea(10, 9));
// //     // RectangleAreaResult();
// //     // System.Console.WriteLine();
// //     // TriangleAreaResult();
// //     // System.Console.WriteLine();
// //     // CircleAreaResult();

// //   }
























// //   public static double RectangleArea(double length, double width)
// //   {
// //     return length * width;
// //   }
// //   public static double CircleArea(double radius)
// //   {
// //     return Math.PI * Math.Pow(radius, 2);
// //   }
// //   public static double TriangleArea(double height, double bottom)
// //   {
// //     return 0.5 * bottom * height;

// //   }

// //   public static void RectangleAreaResult()
// //   {
// //     double result = RectangleArea(2.500, 1.500);
// //     int mexicanPesos = 180;
// //     System.Console.WriteLine($"The RectangleArea of the blueprint is {result}");

// //     double totalCost = mexicanPesos * result;
// //     Console.WriteLine($"The cost for the flooring material will be {totalCost}");


// //   }
// //   public static void TriangleAreaResult()
// //   {
// //     double result = TriangleArea(500, 750);
// //     System.Console.WriteLine($"The TriangleArea of the bluepirnt is {result}");
// //   }

// //   public static void CircleAreaResult()
// //   {
// //     double result = CircleArea(375) / 2;
// //     System.Console.WriteLine($"The result of CircleArea is {result}");
// //   }
// // }