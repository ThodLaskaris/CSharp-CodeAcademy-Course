class Library
{
  private List<Book> books = new();
  public void AddBook(Book book)
  {
    books.Add(book);
  }

  public void SearchAllBooksByTitle(string title)
  {
    if (string.IsNullOrEmpty(title))
    {
      Console.WriteLine("Title cannot be empty");
      return;
    }
    if (books.Count == 0)
    {
      Console.WriteLine("No books in the library");
      return;
    }

    bool found = false;
    foreach (var book in books)
    {
      if (book.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
      {
        Console.WriteLine($"Found: {book.Title} by {book.Author}");
        found = true;
      }
    }
    if (!found)
    {
      Console.WriteLine("No books found with that title.");
    }
  }
  public void DisplayAllBooks()
  {
    if (books.Count == 0)
    {
      Console.WriteLine("No books in the library");

    }
    else
    {
      foreach (var book in books)
      {
        Console.WriteLine($"Title: {book.Title}, Author: {book.Author}\n");
      }
      Console.WriteLine($"Total books: {books.Count}");
    }
  }
  public List<Book> SearchBooksByAuthor(string author)
  {
    List<Book> foundBooks = new();
    if (string.IsNullOrEmpty(author) || books.Count == 0)
      return new List<Book>();
    foreach (var book in books)
    {
      if (book.Author.Contains(author, StringComparison.OrdinalIgnoreCase))
      {
        foundBooks.Add(book);
      }
    }
    return foundBooks;
  }
}