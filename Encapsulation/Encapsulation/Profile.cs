using System;
using System.Runtime.CompilerServices;
//  Users able to interact with their profile.
/*
Create a new profile with some information
Add Hobbies.
View Profile.
*/
public class Profile
{

  public string Name { get; set; }
  private int Age;
  public int age
  {
    get => Age;
    set
    {
      if (value < 0 || value > 95)
      {
        throw new ArgumentException("Age must be between 0 and 95.");
      }
    }
  }
  public string Country { get; set; }
  public string City { get; set; }
  public string Pronnouns { get; set; }
  public string[] Hobbies { get; set; } = Array.Empty<string>();

  public Profile(string name, int age, string country, string city, string pronnous = "they/them")
  {
    Name = name;
    Age = age;
    Country = country;
    City = city;
    Pronnouns = pronnous;
  }
  // Method to view the profile information
  public string ViewProfile()
  {
    string hobbiesList = "None";
    if (Hobbies.Length > 0)
    {
      hobbiesList = string.Empty;
      foreach (var hobby in Hobbies)
      {
        hobbiesList += hobby + ", ";
      }
      hobbiesList = hobbiesList.TrimEnd(',', ' '); // Remove trailing comma and space
    }
    return $"Name: {Name}, Age: {Age}, Country: {Country}, City: {City}, Pronnouns: {Pronnouns}, Hobbies: {hobbiesList}";

  }

  public void SetHobbies(string[] hobbies)
  {
    this.Hobbies = hobbies;
  }
}
