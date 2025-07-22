class Rover
{
  public string Alias { get; private set; }

  public int YearLanded { get; private set; }

  public Rover(string alias, int year)
  {
    Alias = alias;
    YearLanded = year;
  }
  public Rover()
  {

  }

  public string GetInfo()
  {
    return $"{Alias} landed in {YearLanded}.";
  }

  public virtual string Explore()
  {
    return "Rover is expolring the surface.";
  }

  public virtual string Collet()
  {
    return "Rover is collecting rocks";
  }
}