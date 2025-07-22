using System;

class Program
{
  static void Main(string[] args)
  {
    //  Library library = new();
    // library.AddBook(new Book
    // {
    //   Title = "1984",
    //   Author = "George Orwell",
    // });
    // library.AddBook(new Book
    // {
    //   Title = "To Kill a Mockingbird",
    //   Author = "Harper Lee",
    // });
    Library library = new();
    Book book1 = new("1984", "George Orwell");
    Book book2 = new("To Kill a Mockingbird", "Harper Lee");
    library.AddBook(book1);
    library.AddBook(book2);
    library.SearchBooksByAuthor("George Orwell");
  }
}