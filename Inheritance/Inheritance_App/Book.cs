using System;

class Book : Resource
{
  public string Author { get; set; }
  public int PageCount { get; set; }
  public Book(string title, string author, int pageCount, string category = "") : base(title, category)
  {
    Author = author;
    PageCount = pageCount;
  }

  public override void GetInfo()
  {
    base.GetInfo();
    System.Console.WriteLine($"Author: {Author}\nPage Count: {PageCount}");
}
}