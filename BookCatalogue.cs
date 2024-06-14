using bookinventory.Models;

namespace bookinventory;

public static class BookCatalogue
{
    private static readonly List<Book> books = new()
    {
            new Book() {
            Id = 1,
            Title = "The Gods are Not to be Blamed",
            Author = "Ola Rotimi",
            Genre = "Drama",
            Price = 19.99M,
            PublicationDate = new DateTime(1999, 8, 20),
            },
            new Book() {
            Id = 2,
            Title = "Things Fall Apart",
            Author = "Chinua Achebe",
            Genre = "Historical Fiction",
            Price = 15.99M,
            PublicationDate = new DateTime(1958, 6, 17),
            },
            new Book() {
            Id = 3,
            Title = "Purple Hibiscus",
            Author = "Chimamanda Ngozi Adichie",
            Genre = "Fiction",
            Price = 14.99M,
            PublicationDate = new DateTime(2003, 10, 30),
            },
            new Book() {
            Id = 4,
            Title = "Half of a Yellow Sun",
            Author = "Chimamanda Ngozi Adichie",
            Genre = "Historical Fiction",
            Price = 18.99M,
            PublicationDate = new DateTime(2006, 9, 12),
            },
    };

    public static Book[] GetBooks()
    {
        return books.ToArray();
    }

    public static void AddBook(Book book)
    {
        book.Id = books.Max(book => book.Id) + 1;
        books.Add(book);
    }

    public static Book GetBook(int id)
    {
        return books.Find(game => game.Id == id) ?? throw new Exception("Could not Find Book") ;

    }
    public static void UpdateBook(Book updatedBook)
    {
        Book existingBook = GetBook(updatedBook.Id);
        existingBook.Title = updatedBook.Title;
        existingBook.Genre = updatedBook.Genre;
        existingBook.Price = updatedBook.Price;
        existingBook.PublicationDate = updatedBook.PublicationDate;
    }

    public static void DeleteBook (int id)
    {
        Book book = GetBook(id);
        books.Remove(book);
    }
}