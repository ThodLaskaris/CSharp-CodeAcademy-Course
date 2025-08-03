using System;

public class Hero
{
  public string Name { get; set; }
  public string Position { get; set; }
  public float Health { get; set; }
  public float Damage { get; set; }
  public int Experience { get; set; }

  public Hero(string name = "Hero", string position = "00", float health = 100, float damage = 5, int experience = 0)
  {
    Name = name;
    Position = position;
    Health = health;
    Damage = damage;
    Experience = experience;
  }
}