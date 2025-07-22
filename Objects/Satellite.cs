class Satellite
{
  public string Alias { get; private set; }
  public int YearLaunched { get; private set; }

  public Satellite(string alias, int yearLaunched)
  {
    Alias = alias;
    YearLaunched = yearLaunched;
  }
  public Satellite()
  {

  }
}