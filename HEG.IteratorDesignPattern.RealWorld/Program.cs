using HEG.IteratorDesignPattern.RealWorld.Iterator;

BookCollection books = new();
books.Add(new Book("Design Patterns", "Gamma et al."));
books.Add(new Book("Refactoring", "Martin Fowler"));
books.Add(new Book("Clean Code", "Robert C. Martin"));

BookIterator iterator = books.CreateIterator();
while (iterator.HasNext())
{
    Book book = iterator.Next();
    Console.WriteLine($"{book.Title} by {book.Author}");
}
