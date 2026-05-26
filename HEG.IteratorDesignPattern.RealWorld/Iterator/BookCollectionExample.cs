namespace HEG.IteratorDesignPattern.RealWorld.Iterator
{
    public record Book(string Title, string Author);

    public class BookCollection
    {
        private readonly List<Book> _books = new();

        public void Add(Book book) => _books.Add(book);

        public BookIterator CreateIterator() => new(_books);
    }

    public class BookIterator
    {
        private readonly IReadOnlyList<Book> _books;
        private int _index;

        public BookIterator(IReadOnlyList<Book> books)
        {
            _books = books;
        }

        public bool HasNext() => _index < _books.Count;

        public Book Next() => _books[_index++];
    }
}
