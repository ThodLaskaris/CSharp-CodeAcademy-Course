using System;

class Program
{
    static void Main(string[] args)
    {
        // Resource book1 = new("C# Programming", "Book", "Available");
        // book1.GetInfo();
        // System.Console.WriteLine("Updating status...\n");
        // book1.UpdateStatus();
        // book1.GetInfo();

        // Book book2 = new("Code: The Hidden Language", "DrSeal#", 396, "Programming");
        // book2.GetInfo();

        // Periodical periodical1 = new("Wired", "Tech", "Monthly");
        // periodical1.UpdateStatus();
        // periodical1.GetInfo();

        Video video1 = new("Inception", "Nolan", 231, "DVD", "Comedy");
        video1.GetInfo();
        System.Console.WriteLine("Updating status...\n");
        video1.UpdateStatus();
        video1.GetInfo();

    }
}