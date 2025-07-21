class Video : Resource
{
  public string Director { get; set; }
  public int RunTime { get; set; }
  private string _mediaType = "DVD";
  public string MediaType
  {
    get { return _mediaType; }
    set
    {
      if (value == "On Demand" || value == "DVD")
      {
        _mediaType = value;
      }
      else
      {
        throw new Exception("Invalid media type.\n'On Demand' or 'DVD' expected.");
      }
    }
  }

  public Video(string title, string director, int runTime, string mediaType, string category = "") : base(title, category, mediaType)
  {
    Director = director;
    RunTime = runTime;
    MediaType = mediaType;
  }
  public override void GetInfo()
  {
    base.GetInfo();
    Console.WriteLine($"Director: {Director}\nRun Time: {RunTime} minutes\nMedia Type: {MediaType}");
  }
  public override void UpdateStatus()
  {

    if (Status == "On Demand")
    {
      Status = "DVD";
    }
    else if (Status == "DVD")
    {
      Status = "On Demand";
    }
    else
    {
      throw new Exception("Invalid status change.");
    }
  }
}