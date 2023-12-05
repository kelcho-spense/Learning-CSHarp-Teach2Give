// See https://aka.ms/new-console-template for more information

using Async__BookMS.services;

bookService bookService = new bookService();

var books = await bookService.GetBooks();

foreach (var book in books)
{
    Console.WriteLine($"Title: {book.Title}");
    Console.WriteLine($"Description: {book.Description}");
    Console.WriteLine($"Date Published: {book.DatePublished}");
    Console.WriteLine();
}
